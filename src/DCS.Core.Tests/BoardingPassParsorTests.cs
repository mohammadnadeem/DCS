using System;
using NUnit.Framework;
using DCS.Core.PassengerService;
using Moq;

namespace DCS.Core.Tests
{
    [TestFixture]
    public class BoardingPassParsorTests
    {
        private string _bpString;

        [SetUp]
        public void SetUp()
        {
            _bpString = "M1DOE/JOHNMR           2LMWIN AMSJFKKL 0463 123Y007F0500 16C5320  8123BXH                                        2A             00KL                         0647352398";
        }

        [Test]
        public void ParseBoardingString_Success_Test()
        {
            // Act
            var result = BoardingPassParsor.ParseBoardingString(_bpString);

            // Assert
            Assert.AreEqual(result.PassengerNameRecord.FirstName, "JOHN");
            Assert.AreEqual(result.PassengerNameRecord.LastName, "DOE");
            Assert.AreEqual(result.PassengerNameRecord.TravelClass, "Y");

            var flight = result.PassengerNameRecord.Flights[0];
            
            Assert.AreEqual(flight.Origin,"AMS");
            Assert.AreEqual(flight.Destination,"JFK");
            Assert.AreEqual(flight.FlightNumber,"0463");
        }

        [Test]
        public void ParseBoardingString_FailsWhenInCorrectBoardingPassStringSupplied_Test()
        {
            // Act
            var result = BoardingPassParsor.ParseBoardingString("some random text as boarding pass string");

            // Assert
            Assert.AreEqual(result.IsSuccess, false);
            Assert.AreEqual(result.Error, "No Passenger Found");
        }

    }
}
