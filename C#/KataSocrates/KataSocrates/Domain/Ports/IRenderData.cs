using System.Collections.Generic;

namespace KataSocrates.Domain
{
    public interface IRenderData
    {
        bool Print(Dictionary<Diet, int> dictionary);
    }
}
