//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAdmissionTestModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentAdmissionTest Model
     /// </summary>
    public partial class PsStudentAdmissionTestModel : AutobahnBase, Interfaces.IPsStudentAdmissionTest
    {
        /// <summary>
        /// The quantitative score on a standardized admission test reported to a postsecondary institution.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// The quantitative score on a standardized admission test reported to a postsecondary institution.
        /// </summary>
        public Guid RefStandardizedAdmissionTestId { get; set; }

        /// <summary>
        /// The quantitative score on a standardized admission test reported to a postsecondary institution.
        /// </summary>
        public System.Decimal? StandardizedAdmissionTestScore { get; set; }

    }
}
