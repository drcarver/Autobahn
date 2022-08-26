//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeProviderModel.cs
//***************************************************************************

using Autobahn.Interfaces.AdultEducation;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeProvider Model
     /// </summary>
    public partial class AeProviderModel : AutobahnBase, IAeProvider
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Level of Institution
        /// <para>
        /// A classification of whether a postsecondary institution's highest level of offering is a program of 4-years or higher (4 year), 2-but-less-than 4-years (2 year), or less than 2-years.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19178">Level of Institution</a>
        /// </para>
        /// </summary>
        public Guid RefLevelOfInstitutionId { get; set; }

    }
}
