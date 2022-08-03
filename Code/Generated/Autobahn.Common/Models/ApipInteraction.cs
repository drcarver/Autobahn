//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ApipInteraction.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ApipInteraction
     /// </summary>
    public partial class ApipInteraction : IApipInteraction
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentItemApip"/> model
        /// </summary>
        public Guid AssessmentItemApipId { get; set; }

        /// <summary>
        /// Defines the ApipInteraction.Xml non nullable property
        /// </summary>
        public System.String Xml { get; set; }

        /// <summary>
        /// Defines the ApipInteraction.SequenceNumber nullable property
        /// </summary>
        public System.Int32? SequenceNumber { get; set; }

        /// <summary>
        /// Defines the ApipInteraction.APIPInteractionSequenceNumber nullable property
        /// </summary>
        public System.Decimal? APIPInteractionSequenceNumber { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefApipInteractionType"/> model
        /// </summary>
        public Guid? RefApipInteractionTypeId { get; set; }

        /// <summary>
        /// Defines the ApipInteraction.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the ApipInteraction.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
