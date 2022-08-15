//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsPriceOfAttendanceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsPriceOfAttendance Model
     /// </summary>
    public partial class PsPriceOfAttendanceModel : AutobahnBase, Interfaces.IPsPriceOfAttendance
    {
        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        public System.String SessionDesignator { get; set; }

    }
}
