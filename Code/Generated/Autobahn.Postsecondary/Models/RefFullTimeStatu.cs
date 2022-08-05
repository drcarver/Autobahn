//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefFullTimeStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefFullTimeStatu Model
     /// </summary>
    public partial class RefFullTimeStatu : ReferenceModelBase, IRefFullTimeStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefFullTimeStatus"/> model
        /// </summary>
        public Guid RefFullTimeStatusId { get; set; }

    }
}
