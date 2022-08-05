//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IServiceProvided.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IServiceProvided
     /// </summary>
    public partial interface IServiceProvided : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ServicesReceived"/> model
        /// </summary>
        Guid ServicesReceivedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServices"/> model
        /// </summary>
        Guid? RefServicesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSupportServiceType"/> model
        /// </summary>
        Guid? RefStudentSupportServiceTypeId { get; set; }

    }
}
