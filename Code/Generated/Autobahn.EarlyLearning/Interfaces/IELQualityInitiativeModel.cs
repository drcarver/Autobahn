//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELQualityInitiativeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELQualityInitiativeModel Interface
     /// </summary>
    public partial interface IELQualityInitiativeModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.MaximumScore non nullable property
        /// </summary>
        System.String MaximumScore { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.MinimumScore non nullable property
        /// </summary>
        System.String MinimumScore { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.ScoreLevel non nullable property
        /// </summary>
        System.String ScoreLevel { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.ParticipationIndicator nullable property
        /// </summary>
        System.Boolean? ParticipationIndicator { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.ParticipationStartDate nullable property
        /// </summary>
        System.DateTime? ParticipationStartDate { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.ParticipationEndDate nullable property
        /// </summary>
        System.DateTime? ParticipationEndDate { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.ProgramHeathSafetyChecklistUseStatus nullable property
        /// </summary>
        System.Boolean? ProgramHeathSafetyChecklistUseStatus { get; set; }

    }
}
