//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELQualityInitiativeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELQualityInitiative Model
     /// </summary>
    public partial class ELQualityInitiativeModel : AutobahnBase, Interfaces.IELQualityInitiativeModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.MaximumScore non nullable property
        /// </summary>
        public System.String MaximumScore { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.MinimumScore non nullable property
        /// </summary>
        public System.String MinimumScore { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.ScoreLevel non nullable property
        /// </summary>
        public System.String ScoreLevel { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.ParticipationIndicator nullable property
        /// </summary>
        public System.Boolean? ParticipationIndicator { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.ParticipationStartDate nullable property
        /// </summary>
        public System.DateTime? ParticipationStartDate { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.ParticipationEndDate nullable property
        /// </summary>
        public System.DateTime? ParticipationEndDate { get; set; }

        /// <summary>
        /// Defines the ELQualityInitiative.ProgramHeathSafetyChecklistUseStatus nullable property
        /// </summary>
        public System.Boolean? ProgramHeathSafetyChecklistUseStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
