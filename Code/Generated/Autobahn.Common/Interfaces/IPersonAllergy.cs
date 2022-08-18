//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonAllergy.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonAllergy Interface
     /// </summary>
    public partial interface IPersonAllergy : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Allergy Reaction Description
        /// <para>
        /// Describes symptoms know to be associated with a person's reaction to an allergen.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20247">Allergy Reaction Description</a>
        /// </para>
        /// </summary>
        System.String ReactionDescription { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAllergySeverity"/> model
        /// </summary>
        Guid? RefAllergySeverityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAllergyType"/> model
        /// </summary>
        Guid RefAllergyTypeId { get; set; }

    }
}
