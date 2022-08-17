//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramServicesReceivedModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IndividualizedProgramServicesReceived Model
     /// </summary>
    public partial class IndividualizedProgramServicesReceivedModel : AutobahnBase, Interfaces.IIndividualizedProgramServicesReceived
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IServicesReceived"/> model
        /// </summary>
        public Guid ServicesReceivedId { get; set; }

    }
}
