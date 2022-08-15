//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELChildService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildService Interface
     /// </summary>
    public partial interface IELChildService : IAutobahnBase
    {
        /// <summary>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </summary>
        Guid? RefEarlyChildhoodServicesReceivedId { get; set; }

    }
}
