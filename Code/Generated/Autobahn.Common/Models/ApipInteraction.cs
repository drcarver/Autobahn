//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ApipInteraction.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The ApipInteraction
     /// </summary>
    public partial class ApipInteraction : AutobahnBase, Interfaces.IApipInteraction
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
