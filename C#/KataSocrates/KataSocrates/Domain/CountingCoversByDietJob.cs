using System.Collections.Generic;

namespace KataSocrates.Domain
{
    public class CountingCoversByDietJob
    {
        private IReaderData _readerData;
        private IDietService _dietService;
        private readonly IRenderData _renderData;

        public CountingCoversByDietJob(IReaderData readerData, IRenderData renderData, IDietService dietService)
        {
            _readerData = readerData;
            _renderData = renderData;
            _dietService = dietService;
        }

        public bool Excecute()
        {
            var participants = _readerData.GetParticipants();
            Dictionary<Diet, int> dictionary = _dietService.AggregateToDictionary(participants);
            var result = _renderData.Print(dictionary);

            return result;
        }
    }
}
