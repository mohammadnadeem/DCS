using System;
using DCS.Core.PassengerService;
using log4net;

namespace DCS.Core
{
    public class CheckInManager
    {
        IPassengerService passengerServiceClient;
        private static readonly ILog logger = LogManager.GetLogger("CheckInManager");

        public CheckInManager()
        {
            passengerServiceClient = new PassengerServiceClient("BasicHttpBinding_IPassengerService");
        }
        public CheckInManager(IPassengerService client)
        {
            passengerServiceClient = client;
        }

        public FindPassengerResult FindPassenger(string boardingPassStr)
        {
            try
            {
                logger.InfoFormat("Finding Passenger for boarding pass string {0}",boardingPassStr);
                FindPassengerRequest findPassengerRequest = new FindPassengerRequest() {
                    BoardingPassString = boardingPassStr
                };
                logger.DebugFormat("Hitting Passenger Service with boarding pass string {0}", boardingPassStr);
                return passengerServiceClient.FindPassenger(findPassengerRequest);                
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }        
        }

        public CheckInResult CheckIn(Guid passengerGuid, decimal weight)
        {
            try
            {
                logger.InfoFormat("Checking in passenger with id [{0}] and weight {1}",passengerGuid, weight);
                return passengerServiceClient.CheckIn(passengerGuid, weight);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }
    }
}
