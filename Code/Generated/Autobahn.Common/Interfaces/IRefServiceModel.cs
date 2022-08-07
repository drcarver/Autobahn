//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefService Interface Model
     /// </summary>
    public partial interface IRefServiceModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefServices"/> model
        /// </summary>
        Guid RefServicesId { get; set; }

    }
}
