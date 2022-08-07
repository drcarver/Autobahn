//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonAllergyModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonAllergyModel Interface
     /// </summary>
    public partial interface IPersonAllergyModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAllergyType"/> model
        /// </summary>
        Guid RefAllergyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAllergySeverity"/> model
        /// </summary>
        Guid? RefAllergySeverityId { get; set; }

        /// <summary>
        /// Defines the PersonAllergy.ReactionDescription non nullable property
        /// </summary>
        System.String ReactionDescription { get; set; }

    }
}
