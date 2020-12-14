using System;
using ExplicitArchitecture.TuneSearchExample.Core.Ports;

namespace TuneSearchAssignment2
{
    public class SearchTermDTO : ISearchTerm
    {
        public SearchTermDTO()
        {
        }

        public string Term { get; set; }
    }
}
