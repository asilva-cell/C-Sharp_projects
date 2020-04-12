using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one match in a tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// the set of teams taht were involved in a particular match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// Winner of a particular match
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Witch round this match is a part of
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
