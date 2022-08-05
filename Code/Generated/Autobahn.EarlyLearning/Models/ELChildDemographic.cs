//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildDemographic.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildDemographic
     /// </summary>
    public partial class ELChildDemographic : AutobahnBase, Interfaces.IELChildDemographic
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the ELChildDemographic.FosterCareStartDate nullable property
        /// </summary>
        public System.DateTime? FosterCareStartDate { get; set; }

        /// <summary>
        /// Defines the ELChildDemographic.FosterCareEndDate nullable property
        /// </summary>
        public System.DateTime? FosterCareEndDate { get; set; }

        /// <summary>
        /// Defines the ELChildDemographic.OtherRaceIndicator nullable property
        /// </summary>
        public System.Boolean? OtherRaceIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
