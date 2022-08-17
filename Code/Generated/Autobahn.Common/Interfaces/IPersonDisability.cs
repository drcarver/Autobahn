//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDisability.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDisability Interface
     /// </summary>
    public partial interface IPersonDisability : IAutobahnBase
    {
        /// <summary>
        /// Disability Status
        /// <para>
        /// An indication of whether a person is classified as disabled under the American's with Disability Act (ADA).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19569">Disability Status</a>
        /// </para>
        /// </summary>
        System.Boolean? DisabilityStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPrimaryDisabilityType"/> model
        /// </summary>
        Guid? PrimaryDisabilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefAccommodationsNeededType"/> model
        /// </summary>
        Guid? RefAccommodationsNeededTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefDisabilityConditionStatusCode"/> model
        /// </summary>
        Guid? RefDisabilityConditionStatusCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefDisabilityConditionType"/> model
        /// </summary>
        Guid? RefDisabilityConditionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefDisabilityDeterminationSourceType"/> model
        /// </summary>
        Guid? RefDisabilityDeterminationSourceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIDEADisabilityType"/> model
        /// </summary>
        Guid? RefIDEADisabilityTypeId { get; set; }

        /// <summary>
        /// Significant Cognitive Disability Indicator
        /// <para>
        /// Student has an existing IDEA disability with cognitive impairments which may prevent him/her from attaining grade-level achievement standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20746">Significant Cognitive Disability Indicator</a>
        /// </para>
        /// </summary>
        System.Boolean? SignificantCognitiveDisabilityIndicator { get; set; }

    }
}
