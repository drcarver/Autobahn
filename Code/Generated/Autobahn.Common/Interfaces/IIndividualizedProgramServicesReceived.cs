//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIndividualizedProgramServicesReceived.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgramServicesReceived
     /// </summary>
    public partial interface IIndividualizedProgramServicesReceived : IAutobahnBase
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
