//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefVisionScreeningStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefVisionScreeningStatu Model
     /// </summary>
    public partial class RefVisionScreeningStatu : ReferenceModelBase, IRefVisionScreeningStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefVisionScreeningStatus"/> model
        /// </summary>
        public Guid RefVisionScreeningStatusId { get; set; }

    }
}
