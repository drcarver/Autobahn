//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefReconstitutedStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefReconstitutedStatu Model
     /// </summary>
    public partial class RefReconstitutedStatu : ReferenceModelBase, IRefReconstitutedStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefReconstitutedStatus"/> model
        /// </summary>
        public Guid RefReconstitutedStatusId { get; set; }

    }
}
