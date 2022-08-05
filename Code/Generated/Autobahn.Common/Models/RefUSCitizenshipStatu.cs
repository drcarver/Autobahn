//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefUSCitizenshipStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefUSCitizenshipStatu Model
     /// </summary>
    public partial class RefUSCitizenshipStatu : ReferenceModelBase, IRefUSCitizenshipStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefUSCitizenshipStatus"/> model
        /// </summary>
        public Guid RefUSCitizenshipStatusId { get; set; }

    }
}
