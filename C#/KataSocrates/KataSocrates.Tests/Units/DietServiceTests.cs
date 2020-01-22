using KataSocrates.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace KataSocrates.Tests
{
    [TestClass]
    public class DietServiceTests
    {
        [TestMethod]
        public void OneVegetarianDietWithSixMeals()
        {
            //Arrange
            DietService dietService = new DietService(); ;

            Dictionary<Diet, int> expectedDictionary = new Dictionary<Diet, int>();
            expectedDictionary.Add(Diet.VEGETARIAN, 6);

            List<Participant> participants = new List<Participant>();
            var bob = new Participant("Bob");
            bob.Diet = Diet.VEGETARIAN;
            participants.Add(bob);

            var participant2 = new ParticipantBuilder()
                                    .WithName("BOB")
                                    .WithDiet(Diet.VEGETARIAN)
                                    .Build();

            //Act
            var result = dietService.AggregateToDictionary(participants);

            //Assert
            Assert.AreEqual(expectedDictionary[Diet.VEGETARIAN], result[Diet.VEGETARIAN]);
        }

        public class ParticipantBuilder
        {
            private string _name;
            private Diet _diet;

            public Participant Build()
            {
                var participant = new Participant(_name);
                participant.Diet = this._diet;
                return participant;

            }

            internal ParticipantBuilder WithDiet(Diet diet)
            {
                this._diet = diet;
                return this;
            }

            internal ParticipantBuilder WithName(string name)
            {
                this._name = name;
                return this;
            }
        }
    }
}
