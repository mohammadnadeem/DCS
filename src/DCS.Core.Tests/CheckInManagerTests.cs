using System;
using NUnit.Framework;
using DCS.Core.PassengerService;
using Moq;

namespace DCS.Core.Tests
{
    [TestFixture]
    public class CheckInManagerTests
    {
        private string _bpString;
        private Mock<IPassengerService> passengerServiceMock;

        [SetUp]
        public void SetUp()
        {
            _bpString = "M1DOE/JOHNMR           2LMWIN AMSJFKKL 0463 123Y007F0500 16C5320  8123BXH                                        2A             00KL                         0647352398";
            passengerServiceMock = new Moq.Mock<IPassengerService>();
        }

        [Test]
        public void FindPassenger_NoPassengerFound_Test()
        {
            // Arrange
            passengerServiceMock.Setup(x => x.FindPassenger(It.IsAny<FindPassengerRequest>()))
             .Returns(new FindPassengerResult() { Error = "No Passenger Found", IsSuccess = false });
            CheckInManager cm = new CheckInManager(passengerServiceMock.Object);

            // Act
            var result = cm.FindPassenger(_bpString);

            // Assert
            Assert.AreEqual(result.Error, "No Passenger Found");
            Assert.AreEqual(result.IsSuccess, false);
        }

        [Test]
        public void FindPassenger_Success_Test()
        {
            // Arrange
            passengerServiceMock.Setup(x => x.FindPassenger(It.IsAny<FindPassengerRequest>()))
             .Returns(new FindPassengerResult() { IsSuccess = true, PassengerNameRecord = new PassengerNameRecord() { FirstName = "Jon", LastName = "Doe" } });
            CheckInManager cm = new CheckInManager(passengerServiceMock.Object);
            
            // Act
            var result = cm.FindPassenger(_bpString);

            // Assert
            Assert.AreEqual(result.PassengerNameRecord.FirstName, "Jon");
            Assert.AreEqual(result.PassengerNameRecord.LastName, "Doe");
            Assert.AreEqual(result.IsSuccess, true);
        }
        
        [Test]
        public void FindPassenger_ThrowsException_Test()
        {
            // Arrange
            passengerServiceMock.Setup(x => x.FindPassenger(It.IsAny<FindPassengerRequest>())).Throws(new Exception());

            CheckInManager cm = new CheckInManager(passengerServiceMock.Object);
            
            // Act & Assert
            Assert.Throws<Exception>(() => cm.FindPassenger(_bpString));
        }

        [Test]
        public void CheckIn_Success_Test()
        {
            // Arrange FindPassenger
            
            passengerServiceMock.Setup(x => x.FindPassenger(It.IsAny<FindPassengerRequest>()))
             .Returns(new FindPassengerResult() { IsSuccess = true, PassengerNameRecord = new PassengerNameRecord() { FirstName = "Jon", LastName = "Doe", Id = new Guid("d72df8f1-bdd6-4cc3-b26c-7ffbdc07d70b"), Allowance = 23 } });
            CheckInManager cm1 = new CheckInManager(passengerServiceMock.Object);

            var findPassengerResult = cm1.FindPassenger(_bpString);

            // Arrange Checkin
            passengerServiceMock.Setup(x => x.CheckIn(findPassengerResult.PassengerNameRecord.Id, findPassengerResult.PassengerNameRecord.Allowance))
             .Returns(new CheckInResult() { IsSuccess = true });
            CheckInManager cm2 = new CheckInManager(passengerServiceMock.Object);

            // Act
            var checkInResult = cm2.CheckIn(findPassengerResult.PassengerNameRecord.Id, findPassengerResult.PassengerNameRecord.Allowance);

            // Assert
            Assert.AreEqual(checkInResult.IsSuccess, true);
        }

    }
}
