//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramServicesReceivedModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IndividualizedProgramServicesReceived Model
     /// </summary>
    public partial class IndividualizedProgramServicesReceivedModel : AutobahnBase, Interfaces.IIndividualizedProgramServicesReceivedModel
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
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
