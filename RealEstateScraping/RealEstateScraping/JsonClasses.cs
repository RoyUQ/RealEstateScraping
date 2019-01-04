using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstateScraping
{
    public class RealResult
    {
        public double latitude { get; set; }
        public string listingId { get; set; }
        public double longitude { get; set; }
    }

    public class TieredResult
    {
        public int tier { get; set; }
        public int count { get; set; }
        public List<RealResult> results { get; set; }
    }

    public class RealRootObject
    {
        public int totalResultsCount { get; set; }
        public List<TieredResult> tieredResults { get; set; }
    }
}
