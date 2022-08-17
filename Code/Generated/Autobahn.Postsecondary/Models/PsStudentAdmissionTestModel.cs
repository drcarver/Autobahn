//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAdmissionTestModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The PsStudentAdmissionTest Model
     /// </summary>
    public partial class PsStudentAdmissionTestModel : AutobahnBase, Interfaces.IPsStudentAdmissionTest
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefStandardizedAdmissionTest"/> model
        /// </summary>
        public Guid RefStandardizedAdmissionTestId { get; set; }

        /// <summary>
        /// Standardized Admission Test Score
        /// <para>
        /// The quantitative score on a standardized admission test reported to a postsecondary institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19265">Standardized Admission Test Score</a>
        /// </para>
        /// </summary>
        public System.Decimal? StandardizedAdmissionTestScore { get; set; }

    }
}
