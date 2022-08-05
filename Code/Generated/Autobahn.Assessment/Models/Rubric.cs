//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   Rubric.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The Rubric
     /// </summary>
    public partial class Rubric : AutobahnBase, Interfaces.IRubric
    {
        /// <summary>
        /// Defines the Rubric.Identifier non nullable property
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Defines the Rubric.Title non nullable property
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Defines the Rubric.UrlReference non nullable property
        /// </summary>
        public System.String UrlReference { get; set; }

        /// <summary>
        /// Defines the Rubric.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
