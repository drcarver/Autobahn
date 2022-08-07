//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefEarlyChildhoodServiceModel.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The RefEarlyChildhoodService Model
     /// </summary>
    public partial class RefEarlyChildhoodServiceModel : ReferenceModelBase, IRefEarlyChildhoodServiceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEarlyChildhoodServices"/> model
        /// </summary>
        public Guid RefEarlyChildhoodServicesId { get; set; }

    }
}
