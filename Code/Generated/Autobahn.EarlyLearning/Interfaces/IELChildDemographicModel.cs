//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELChildDemographicModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildDemographicModel Interface
     /// </summary>
    public partial interface IELChildDemographicModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the ELChildDemographic.FosterCareStartDate nullable property
        /// </summary>
        System.DateTime? FosterCareStartDate { get; set; }

        /// <summary>
        /// Defines the ELChildDemographic.FosterCareEndDate nullable property
        /// </summary>
        System.DateTime? FosterCareEndDate { get; set; }

        /// <summary>
        /// Defines the ELChildDemographic.OtherRaceIndicator nullable property
        /// </summary>
        System.Boolean? OtherRaceIndicator { get; set; }

    }
}
