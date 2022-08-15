//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsPriceOfAttendance.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsPriceOfAttendance Interface
     /// </summary>
    public partial interface IPsPriceOfAttendance : IAutobahnBase
    {
        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// </summary>
        System.String SessionDesignator { get; set; }

    }
}
