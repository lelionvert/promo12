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
            Participant participant = new Participant(typeRoom);
            int price = participant.CalculatePrice();
            Assert.AreEqual(610, price);
        }

        [Test]
        public void TwinRoom()
        {
            TypeRoom typeRoom = TypeRoom.Twin;
            Participant participant = new Participant(typeRoom);
            int price = participant.CalculatePrice();
            Assert.AreEqual(510, price);
        }
    }
}
