//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefEarlyChildhoodService.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefEarlyChildhoodService Interface
     /// </summary>
    public partial interface IRefEarlyChildhoodService : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEarlyChildhoodServices"/> model
        /// </summary>
        Guid RefEarlyChildhoodServicesId { get; set; }

    }
}
