//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IAeProvider.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The IAeProvider Interface
     /// </summary>
    public partial interface IAeProvider : IAutobahnBase
    {
        /// <summary>
        /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
        /// </summary>
        Guid RefLevelOfInstitutionId { get; set; }

    }
}
