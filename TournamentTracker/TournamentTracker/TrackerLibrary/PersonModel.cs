using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one member of the team
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The first anme of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The primary email address of the person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The primary cellphone number of the person
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
