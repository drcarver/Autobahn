//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefService.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefService Model
     /// </summary>
    public partial class RefService : ReferenceModelBase, IRefService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefServices"/> model
        /// </summary>
        public Guid RefServicesId { get; set; }

    }
}
