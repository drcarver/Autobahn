//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmploymentStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefEmploymentStatu Model
     /// </summary>
    public partial class RefEmploymentStatu : ReferenceModelBase, IRefEmploymentStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefEmploymentStatus"/> model
        /// </summary>
        public Guid RefEmploymentStatusId { get; set; }

    }
}
