//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IApipInteraction.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IApipInteraction
     /// </summary>
    public partial interface IApipInteraction
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemApip"/> model
        /// </summary>
        Guid AssessmentItemApipId { get; set; }

        /// <summary>
        /// Defines the ApipInteraction.Xml non nullable property
        /// </summary>
        System.String Xml { get; set; }

        /// <summary>
        /// Defines the ApipInteraction.SequenceNumber nullable property
        /// </summary>
        System.Int32? SequenceNumber { get; set; }

        /// <summary>
        /// Defines the ApipInteraction.APIPInteractionSequenceNumber nullable property
        /// </summary>
        System.Decimal? APIPInteractionSequenceNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefApipInteractionType"/> model
        /// </summary>
        Guid? RefApipInteractionTypeId { get; set; }

        /// <summary>
        /// Defines the ApipInteraction.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ApipInteraction.RecordEndDateTime nullable property
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
