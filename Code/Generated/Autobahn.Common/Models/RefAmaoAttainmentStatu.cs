//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAmaoAttainmentStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefAmaoAttainmentStatu Model
     /// </summary>
    public partial class RefAmaoAttainmentStatu : ReferenceModelBase, IRefAmaoAttainmentStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAmaoAttainmentStatus"/> model
        /// </summary>
        public Guid RefAmaoAttainmentStatusId { get; set; }

    }
}
