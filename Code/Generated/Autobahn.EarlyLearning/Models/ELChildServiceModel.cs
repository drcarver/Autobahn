//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildService Model
     /// </summary>
    public partial class ELChildServiceModel : AutobahnBase, Interfaces.IELChildService
    {
        /// <summary>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing additional resources.
        /// </summary>
        public Guid? RefEarlyChildhoodServicesReceivedId { get; set; }

    }
}
