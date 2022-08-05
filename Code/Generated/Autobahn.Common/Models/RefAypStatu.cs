//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAypStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefAypStatu Model
     /// </summary>
    public partial class RefAypStatu : ReferenceModelBase, IRefAypStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAypStatus"/> model
        /// </summary>
        public Guid RefAypStatusId { get; set; }

    }
}
