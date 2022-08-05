//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDSessionStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefPDSessionStatu Model
     /// </summary>
    public partial class RefPDSessionStatu : ReferenceModelBase, IRefPDSessionStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefPDSessionStatus"/> model
        /// </summary>
        public Guid RefPDSessionStatusId { get; set; }

    }
}
