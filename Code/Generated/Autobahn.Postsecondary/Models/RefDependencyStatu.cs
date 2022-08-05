//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefDependencyStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefDependencyStatu Model
     /// </summary>
    public partial class RefDependencyStatu : ReferenceModelBase, IRefDependencyStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefDependencyStatus"/> model
        /// </summary>
        public Guid RefDependencyStatusId { get; set; }

    }
}
