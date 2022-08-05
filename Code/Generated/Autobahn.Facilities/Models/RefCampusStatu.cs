//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefCampusStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The RefCampusStatu Model
     /// </summary>
    public partial class RefCampusStatu : ReferenceModelBase, IRefCampusStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCampusStatus"/> model
        /// </summary>
        public Guid RefCampusStatusId { get; set; }

    }
}
