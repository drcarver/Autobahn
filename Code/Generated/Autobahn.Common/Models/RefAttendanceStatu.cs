//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAttendanceStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefAttendanceStatu Model
     /// </summary>
    public partial class RefAttendanceStatu : ReferenceModelBase, IRefAttendanceStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAttendanceStatus"/> model
        /// </summary>
        public Guid RefAttendanceStatusId { get; set; }

    }
}
