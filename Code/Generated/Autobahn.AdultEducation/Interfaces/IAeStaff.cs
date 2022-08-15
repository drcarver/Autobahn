//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IAeStaff.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeStaff Interface
     /// </summary>
    public partial interface IAeStaff : IAutobahnBase
    {
        /// <summary>
        /// The titles of employment, official status, or rank of adult education staff.
        /// </summary>
        Guid? RefAeStaffClassificationId { get; set; }

    }
}
