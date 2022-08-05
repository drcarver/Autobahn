//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefInstructionalActivityHour.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefInstructionalActivityHour Model
     /// </summary>
    public partial class RefInstructionalActivityHour : ReferenceModelBase, IRefInstructionalActivityHour
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefInstructionalActivityHours"/> model
        /// </summary>
        public Guid RefInstructionalActivityHoursId { get; set; }

    }
}
