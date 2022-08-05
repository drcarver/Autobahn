//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefVirtualSchoolStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefVirtualSchoolStatu Model
     /// </summary>
    public partial class RefVirtualSchoolStatu : ReferenceModelBase, IRefVirtualSchoolStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefVirtualSchoolStatus"/> model
        /// </summary>
        public Guid RefVirtualSchoolStatusId { get; set; }

    }
}
