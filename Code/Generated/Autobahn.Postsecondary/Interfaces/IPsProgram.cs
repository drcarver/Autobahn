//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsProgram.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsProgram Interface
     /// </summary>
    public partial interface IPsProgram : IAutobahnBase
    {
        /// <summary>
        /// Normal Length of Time for Completion
        /// <para>
        /// The amount of time necessary for a person to complete all requirements for a degree or certificate according to the institution's catalog. This is typically 4 years (8 semesters or trimesters, or 12 quarters, excluding summer terms) for a bachelor's degree in a standard term-based institution; 2 years (4 semesters or trimesters, or 6 quarters, excluding summer terms) for an associate's degree in a standard term-based institution; and the various scheduled times for certificate programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19197">Normal Length of Time for Completion</a>
        /// </para>
        /// </summary>
        System.String NormalLengthTimeForCompletion { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Program Length Hours
        /// <para>
        /// The normal length in credit/contact hours of a person's program as published in the institution's catalogue, website, or other official documents.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19223">Program Length Hours</a>
        /// </para>
        /// </summary>
        System.Decimal? ProgramLengthHours { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        Guid? RefCipCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipVersion"/> model
        /// </summary>
        Guid? RefCipVersionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDQPCategoriesOfLearning"/> model
        /// </summary>
        Guid? RefDQPCategoriesOfLearningId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramLengthHoursType"/> model
        /// </summary>
        Guid? RefProgramLengthHoursTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPSProgramLevel"/> model
        /// </summary>
        Guid? RefPSProgramLevelId { get; set; }

        /// <summary>
        /// Normal Length of Time for Completion Units
        /// <para>
        /// The unit of measurement for length of time for completion.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19198">Normal Length of Time for Completion Units</a>
        /// </para>
        /// </summary>
        Guid? RefTimeForCompletionUnitsId { get; set; }

    }
}
