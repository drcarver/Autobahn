//***************************************************************************
//* DomainName: Adult Education (AE) Interfaces (used by both models and View Models
//* FileName:   IAeProvider.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.AdultEducation
{
     /// <summary>
     /// The IAeProvider Interface
     /// </summary>
    public partial interface IAeProvider : IAutobahnBase
    {
        #region IAeProvider
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Level of Institution
        /// <para>
        /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19178">Level of Institution</a>
        /// </para>
        /// </summary>
        Guid RefLevelOfInstitutionId { get; set; }

        #endregion
    }
}