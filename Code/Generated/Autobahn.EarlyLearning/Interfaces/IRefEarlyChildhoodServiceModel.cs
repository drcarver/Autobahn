//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefEarlyChildhoodServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefEarlyChildhoodService Interface Model
     /// </summary>
    public partial interface IRefEarlyChildhoodServiceModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEarlyChildhoodServices"/> model
        /// </summary>
        Guid RefEarlyChildhoodServicesId { get; set; }

    }
}
