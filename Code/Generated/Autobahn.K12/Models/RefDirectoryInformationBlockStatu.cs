//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefDirectoryInformationBlockStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefDirectoryInformationBlockStatu Model
     /// </summary>
    public partial class RefDirectoryInformationBlockStatu : ReferenceModelBase, IRefDirectoryInformationBlockStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDirectoryInformationBlockStatus"/> model
        /// </summary>
        public Guid RefDirectoryInformationBlockStatusId { get; set; }

    }
}
