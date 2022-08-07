//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefContinuationOfServiceModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefContinuationOfService Model
     /// </summary>
    public partial class RefContinuationOfServiceModel : ReferenceModelBase, IRefContinuationOfServiceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefContinuationOfServicesReason"/> model
        /// </summary>
        public Guid RefContinuationOfServicesReasonId { get; set; }

    }
}
