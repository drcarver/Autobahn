//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELQualityInitiative.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELQualityInitiative Interface
     /// </summary>
    public partial interface IELQualityInitiative : IAutobahnBase
    {
        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        System.String MaximumScore { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        System.String MinimumScore { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        System.DateTime? ParticipationEndDate { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        System.Boolean? ParticipationIndicator { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        System.DateTime? ParticipationStartDate { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        System.Boolean? ProgramHeathSafetyChecklistUseStatus { get; set; }

        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        System.String ScoreLevel { get; set; }

    }
}
