//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefContinuationOfService.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefContinuationOfService Interface
     /// </summary>
    public partial interface IRefContinuationOfService : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefContinuationOfServicesReason"/> model
        /// </summary>
        Guid RefContinuationOfServicesReasonId { get; set; }

    }
}
