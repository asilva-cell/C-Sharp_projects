using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// One team in a matchup
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// One team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// The score of a particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The match that this team came from as winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
