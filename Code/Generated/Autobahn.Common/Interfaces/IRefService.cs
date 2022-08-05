//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefService.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The RefService Interface
     /// </summary>
    public partial interface IRefService : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefServices"/> model
        /// </summary>
        Guid RefServicesId { get; set; }

    }
}
