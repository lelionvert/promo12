using KataSocrates.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace KataSocrates.Tests
{
    [TestClass]
    [Feature(Name = "CountCoverByDiet")]
    public class Given_a_Vegetarian__Participant
    {
        [TestMethod]
        public void When_I_Count_Covers_By_Diet_Then_I_Print_CountingResult()
        {
            //arrange
            var participants = new List<Participant>();
            //Question : Id
            var bob = new Participant("Bob");
            bob.Diet = Diet.VEGETARIAN;
            participants.Add(bob);

            Dictionary<Diet, int> dietDictionaryCounter = new Dictionary<Diet, int>();
            dietDictionaryCounter.Add(Diet.VEGETARIAN, 6);

            var readerDataMock = new Mock<IReaderData>();
            readerDataMock.Setup(r => r.GetParticipants()).Returns(participants);
            
            var dietServiceMock = new Mock<IDietService>();
            dietServiceMock.Setup(d => d.AggregateToDictionary(participants)).Returns(dietDictionaryCounter);

            var renderDataMock = new Mock<IRenderData>();
            renderDataMock.Setup(r => r.Print(dietDictionaryCounter)).Returns(true);

            var job = new CountingCoversByDietJob(readerDataMock.Object, renderDataMock.Object, dietServiceMock.Object);

            //act
            var hasBeenPrinted = job.Excecute();

            //assert
            Assert.IsTrue(hasBeenPrinted);
        }
    }
}
