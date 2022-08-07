//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefContinuationOfServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefContinuationOfService Interface Model
     /// </summary>
    public partial interface IRefContinuationOfServiceModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefContinuationOfServicesReason"/> model
        /// </summary>
        Guid RefContinuationOfServicesReasonId { get; set; }

    }
}
