//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramServicesReceivedModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramServicesReceivedModel Interface
     /// </summary>
    public partial interface IIndividualizedProgramServicesReceivedModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="ServicesReceived"/> model
        /// </summary>
        Guid ServicesReceivedId { get; set; }

    }
}
