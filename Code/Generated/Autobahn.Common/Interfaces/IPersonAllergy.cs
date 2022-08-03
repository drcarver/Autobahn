//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonAllergy.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonAllergy
     /// </summary>
    public partial interface IPersonAllergy
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

        /// <summary>
        /// Defines the PersonAllergy.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonAllergy.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
