//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDisabilityModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDisability Model
     /// </summary>
    public partial class PersonDisabilityModel : AutobahnBase, Interfaces.IPersonDisability
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
        public System.Boolean? DisabilityStatus { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPrimaryDisabilityType"/> model
        /// </summary>
        public Guid? PrimaryDisabilityTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationsNeededType"/> model
        /// </summary>
        public Guid? RefAccommodationsNeededTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionStatusCode"/> model
        /// </summary>
        public Guid? RefDisabilityConditionStatusCodeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityConditionType"/> model
        /// </summary>
        public Guid? RefDisabilityConditionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDisabilityDeterminationSourceType"/> model
        /// </summary>
        public Guid? RefDisabilityDeterminationSourceTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEADisabilityType"/> model
        /// </summary>
        public Guid? RefIDEADisabilityTypeId { get; set; }

        /// <summary>
        /// Significant Cognitive Disability Indicator
        /// <para>
        /// Student has an existing IDEA disability with cognitive impairments which may prevent him/her from attaining grade-level achievement standards.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20746">Significant Cognitive Disability Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? SignificantCognitiveDisabilityIndicator { get; set; }

    }
}
