//***************************************************************************
//* DomainName: Postsecondary (PS) Interfaces (used by both models and View Models
//* FileName:   IPsStaffEmployment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStaffEmployment Interface
     /// </summary>
    public partial interface IPsStaffEmployment : IAutobahnBase
    {
        /// <summary>
        /// The Integrated Postsecondary Education Data System (IPEDS) occupational categories used to report employees.
        /// </summary>
        Guid? RefIpedsOccupationalCategoryId { get; set; }

    }
}
