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
        /// Quality Initiative Maximum Score
        /// <para>
        /// The maximum score option for the QRIS or other quality initiative.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20432">Quality Initiative Maximum Score</a>
        /// </para>
        /// </summary>
        System.String MaximumScore { get; set; }

        /// <summary>
        /// Quality Initiative Minimum Score
        /// <para>
        /// The minimum score option for the QRIS or other quality initiative.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20433">Quality Initiative Minimum Score</a>
        /// </para>
        /// </summary>
        System.String MinimumScore { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Quality Initiative Participation End Date
        /// <para>
        /// The quality initiative end date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20436">Quality Initiative Participation End Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ParticipationEndDate { get; set; }

        /// <summary>
        /// Quality Initiative Participation Indicator
        /// <para>
        /// Site participates in a quality improvement initiative component other than QRIS.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20435">Quality Initiative Participation Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? ParticipationIndicator { get; set; }

        /// <summary>
        /// Quality Initiative Participation Start Date
        /// <para>
        /// The quality initiative start date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20437">Quality Initiative Participation Start Date</a>
        /// </para>
        /// </summary>
        System.DateTime? ParticipationStartDate { get; set; }

        /// <summary>
        /// Program Health Safety Checklist Use Status
        /// <para>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19851">Program Health Safety Checklist Use Status</a>
        /// </para>
        /// </summary>
        System.Boolean? ProgramHeathSafetyChecklistUseStatus { get; set; }

        /// <summary>
        /// Quality Initiative Score Level
        /// <para>
        /// The score, rating or level received by a program for its Quality Rating and Improvement System (QRIS) or other quality initiative.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20434">Quality Initiative Score Level</a>
        /// </para>
        /// </summary>
        System.String ScoreLevel { get; set; }

    }
}
