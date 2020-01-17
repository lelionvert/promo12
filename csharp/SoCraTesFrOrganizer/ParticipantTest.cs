using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SoCraTesFrOrganizer
{
    [TestFixture]
    public class ParticipantTest
    {
        [Test]
        public void SingleRoom()
        {
            TypeRoom typeRoom = TypeRoom.Single;
            Participant participant = new Participant(typeRoom, CheckIn.Of("29/10/2020 20:00"), null);
            int price = participant.CalculatePrice();
            Assert.AreEqual(610, price);
        }

        [Test]
        public void TwinRoom()
        {
            TypeRoom typeRoom = TypeRoom.Twin;
            Participant participant = new Participant(typeRoom, CheckIn.Of("29/10/2020 20:00"), null);
            int price = participant.CalculatePrice();
            Assert.AreEqual(510, price);
        }

        [Test]
        public void TripleRoom()
        {
            TypeRoom typeRoom = TypeRoom.Triple;
            Participant participant = new Participant(typeRoom, CheckIn.Of("29/10/2020 20:00"), null);
            int price = participant.CalculatePrice();
            Assert.AreEqual(410, price);
        }

        [Test]
        public void NoRoom()
        {
            TypeRoom typeRoom = TypeRoom.NoAccommodation;
            Participant participant = new Participant(typeRoom, CheckIn.Of("29/10/2020 20:00"), null);
            int price = participant.CalculatePrice();
            Assert.AreEqual(240, price);
        }

        [Test]
        public void NoRoomAndFirstMealIncludeAtThursday()
        {
            TypeRoom typeRoom = TypeRoom.NoAccommodation;
            CheckIn checkin = CheckIn.Of("29/10/2020 20:00");
            Participant participant = new Participant(typeRoom, checkin, null);
            int price = participant.CalculatePrice();
            Assert.AreEqual(240, price);
        }

        [Test]
        public void NoRoomAndFirstMealNotInclude()
        {
            TypeRoom typeRoom = TypeRoom.NoAccommodation;
            CheckIn checkin = CheckIn.Of("30/10/2020 02:00");
            Meals meal = new Meals(new DateTime(2020, 10, 29, 16, 0, 0), new DateTime(2020, 10, 30, 1,0,0));
            Participant participant = new Participant(typeRoom, checkin, meal);
            int price = participant.CalculatePrice();
            Assert.AreEqual(200, price);
        }

        [Test]
        public void NoRoomAndFirstMealIncludeAtFriday()
        {
            TypeRoom typeRoom = TypeRoom.NoAccommodation;
            CheckIn checkin = CheckIn.Of("30/10/2020 00:30");
            Meals meal = new Meals(new DateTime(2020, 10, 29, 16, 0, 0), new DateTime(2020, 10, 30, 1, 0, 0));
            Participant participant = new Participant(typeRoom, checkin, meal);
            int price = participant.CalculatePrice();
            Assert.AreEqual(240, price);
        }
    }
}
