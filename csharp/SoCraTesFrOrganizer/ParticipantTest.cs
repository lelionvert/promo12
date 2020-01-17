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
            Participant participant = new Participant(typeRoom, Check.Of("29/10/2020 20:00"), Check.Of("01/11/2020 15:00"), null, new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0)));
            int price = participant.CalculatePrice();
            Assert.AreEqual(610, price);
        }

        [Test]
        public void TwinRoom()
        {
            TypeRoom typeRoom = TypeRoom.Twin;
            Participant participant = new Participant(typeRoom, Check.Of("29/10/2020 20:00"), Check.Of("01/11/2020 15:00"), null, new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0)));
            int price = participant.CalculatePrice();
            Assert.AreEqual(510, price);
        }

        [Test]
        public void TripleRoom()
        {
            TypeRoom typeRoom = TypeRoom.Triple;
            Participant participant = new Participant(typeRoom, Check.Of("29/10/2020 20:00"), Check.Of("01/11/2020 15:00"), null, new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0)));
            int price = participant.CalculatePrice();
            Assert.AreEqual(410, price);
        }

        [Test]
        public void NoRoom()
        {
            TypeRoom typeRoom = TypeRoom.NoAccommodation;
            Participant participant = new Participant(typeRoom, Check.Of("29/10/2020 20:00"), Check.Of("01/11/2020 15:00"), null, new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0)));
            int price = participant.CalculatePrice();
            Assert.AreEqual(240, price);
        }

        [Test]
        public void NoRoomAndFirstMealIncludeAtThursday()
        {
            TypeRoom typeRoom = TypeRoom.NoAccommodation;
            Check checkin = Check.Of("29/10/2020 20:00");
            Participant participant = new Participant(typeRoom, checkin, Check.Of("01/11/2020 15:00"), null, new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0)));
            int price = participant.CalculatePrice();
            Assert.AreEqual(240, price);
        }

        [Test]
        public void NoRoomAndFirstMealNotInclude()
        {
            TypeRoom typeRoom = TypeRoom.NoAccommodation;
            Check checkin = Check.Of("30/10/2020 02:00");
            Meals meal = new Meals(new DateTime(2020, 10, 29, 16, 0, 0), new DateTime(2020, 10, 30, 1,0,0));
            Participant participant = new Participant(typeRoom, checkin, Check.Of("01/11/2020 15:00"), meal, new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0)));
            int price = participant.CalculatePrice();
            Assert.AreEqual(200, price);
        }

        [Test]
        public void NoRoomAndFirstMealIncludeAtFriday()
        {
            TypeRoom typeRoom = TypeRoom.NoAccommodation;
            Check checkin = Check.Of("30/10/2020 00:30");
            Meals meal = new Meals(new DateTime(2020, 10, 29, 16, 0, 0), new DateTime(2020, 10, 30, 1, 0, 0));
            Participant participant = new Participant(typeRoom, checkin, Check.Of("01/11/2020 15:00"), meal, new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0)));
            int price = participant.CalculatePrice();
            Assert.AreEqual(240, price);
        }

        [Test]
        public void SingleRoomAndLastMealInclude()
        {
            TypeRoom typeRoom = TypeRoom.Single;
            Check checkOut = Check.Of("01/11/2020 15:00");
            Meals meal = new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0));
            Participant participant = new Participant(typeRoom, checkOut, Check.Of("01/11/2020 15:00"), meal, new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0)));
            int price = participant.CalculatePrice();
            Assert.AreEqual(610, price);
        }

        [Test]
        public void SingleRoomAndLastMealNotInclude()
        {
            TypeRoom typeRoom = TypeRoom.Single;
            Check checkOut = Check.Of("01/11/2020 13:00");
            Meals mealIn = new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0));
            Meals mealOut = new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0));
            Participant participant = new Participant(typeRoom, checkOut, Check.Of("01/11/2020 15:00"), mealIn, mealOut);
            int price = participant.CalculatePrice();
            Assert.AreEqual(570, price);
        }

        [Test]
        public void SingleRoomAndNotIncludeTwoMeals()
        {
            TypeRoom typeRoom = TypeRoom.Single;
            Check checkIn = Check.Of("30/10/2020 02:00");
            Check checkOut = Check.Of("01/11/2020 13:00");
            Meals mealIn = new Meals(new DateTime(2020, 10, 29, 16, 0, 0), new DateTime(2020, 10, 30, 1, 0, 0));
            Meals mealOut = new Meals(new DateTime(2020, 11, 01, 14, 0, 0), new DateTime(2020, 11, 2, 0, 0, 0));
            
            Participant participant = new Participant(typeRoom,checkIn, checkOut, mealIn, mealOut);
            int price = participant.CalculatePrice();
            Assert.AreEqual(530, price);
        }
    }
}
