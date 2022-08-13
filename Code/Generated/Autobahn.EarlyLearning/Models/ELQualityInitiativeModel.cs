//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELQualityInitiativeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELQualityInitiative Model
     /// </summary>
    public partial class ELQualityInitiativeModel : AutobahnBase, Interfaces.IELQualityInitiative
    {
        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.String MaximumScore { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.String MinimumScore { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.DateTime? ParticipationEndDate { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.Boolean? ParticipationIndicator { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.DateTime? ParticipationStartDate { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.Boolean? ProgramHeathSafetyChecklistUseStatus { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.String ScoreLevel { get; set; }

    }
}
