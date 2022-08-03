//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramServicesReceived.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramServicesReceived
     /// </summary>
    public partial class IndividualizedProgramServicesReceived : IIndividualizedProgramServicesReceived
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServicesReceived"/> model
        /// </summary>
        public Guid ServicesReceivedId { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramServicesReceived.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IndividualizedProgramServicesReceived.RecordEndDateTime nullable property
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
