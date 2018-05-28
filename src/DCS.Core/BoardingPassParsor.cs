using System;
using Newtonsoft.Json.Linq;
using DCS.Core.PassengerService;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DCS.Core
{
    public class BoardingPassParsor
    {
        public static FindPassengerResult ParseBoardingString(string boardingPassStr)
        {
            FindPassengerResult findPassengerResult = new FindPassengerResult();
            PassengerNameRecord pnr = new PassengerNameRecord();

            using (WebClient wc = new WebClient())
            {
                var uri = new Uri(@"https://www.flighthistorian.com/boarding-pass/json/" + 
                    boardingPassStr.Replace("/", "%2F"));
                var json_data = wc.DownloadString(uri);
                dynamic jdata = JObject.Parse(json_data);

                // loop through unique mandatory 
                foreach (var uniqueMandatory in jdata.unique.mandatory)
                {
                    foreach (var item in uniqueMandatory)
                    {
                        var description = item.description.Value.ToString();
                        var value = item.raw.Value;

                        switch (description)
                        {
                            case "Passenger Name":
                                var firstNameWithTitle = value.Split('/')[1].TrimEnd(' ');
                                if (firstNameWithTitle.EndsWith("MR"))
                                    pnr.FirstName = firstNameWithTitle.Substring(0, firstNameWithTitle.Length - "MR".Length);
                                if (firstNameWithTitle.EndsWith("MRS"))
                                    pnr.FirstName = firstNameWithTitle.Substring(0, firstNameWithTitle.Length - "MRS".Length);
                                break;
                            default:
                                break;
                        }
                    }

                    List<Flight> flights = new List<Flight>();
                    // loop through reapead mandatory
                    foreach (var repeated in jdata.repeated)
                    {
                        Flight f = new Flight();
                        foreach (var repeatedMandatory in repeated.mandatory)
                        {
                            foreach (var item in repeatedMandatory)
                            {
                                var description = item.description.Value.ToString();
                                var value = item.raw.Value;

                                switch (description)
                                {
                                    case "Operating Carrier PNR Code":
                                        break;
                                    case "From City Airport Code":
                                        f.Origin = value;
                                        break;
                                    case "To City Airport Code":
                                        f.Destination = value;
                                        break;
                                    case "Operating Carrier Designator":
                                        break;
                                    case "Flight Number":
                                        f.FlightNumber = value;
                                        break;
                                    case "Date of Flight":
                                        break;
                                    case "Compartment Code":
                                        pnr.TravelClass = value;
                                        break;
                                    case "Seat Number":
                                        break;
                                    case "Check-In Sequence Number":
                                        break;
                                    case "Passenger Status":
                                        pnr.CheckedIn = value.Equals("1") ? true : false;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                        flights.Add(f);
                    }
                    pnr.Flights = flights.ToArray();
                }
            }

            findPassengerResult.PassengerNameRecord = pnr;
            findPassengerResult.IsSuccess = true;

            return findPassengerResult;

        }
    }
}
