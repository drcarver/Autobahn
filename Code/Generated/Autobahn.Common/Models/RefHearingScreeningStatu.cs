//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefHearingScreeningStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefHearingScreeningStatu Model
     /// </summary>
    public partial class RefHearingScreeningStatu : ReferenceModelBase, IRefHearingScreeningStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefHearingScreeningStatus"/> model
        /// </summary>
        public Guid RefHearingScreeningStatusId { get; set; }

    }
}
