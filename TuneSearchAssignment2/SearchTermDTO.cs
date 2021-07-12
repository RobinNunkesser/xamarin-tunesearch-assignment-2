using System;
using MusicPorts;

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
