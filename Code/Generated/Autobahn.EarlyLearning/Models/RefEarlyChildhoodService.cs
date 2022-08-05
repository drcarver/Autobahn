//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefEarlyChildhoodService.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.EarlyLearning.Interfaces;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The RefEarlyChildhoodService Model
     /// </summary>
    public partial class RefEarlyChildhoodService : ReferenceModelBase, IRefEarlyChildhoodService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEarlyChildhoodServices"/> model
        /// </summary>
        public Guid RefEarlyChildhoodServicesId { get; set; }

    }
}
