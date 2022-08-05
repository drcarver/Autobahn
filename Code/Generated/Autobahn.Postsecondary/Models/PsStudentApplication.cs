//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentApplication.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentApplication
     /// </summary>
    public partial class PsStudentApplication : AutobahnBase, Interfaces.IPsStudentApplication
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.PostsecondaryApplicant nullable property
        /// </summary>
        public System.Boolean? PostsecondaryApplicant { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.GradePointAverageCumulative nullable property
        /// </summary>
        public System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.HighSchoolPercentile nullable property
        /// </summary>
        public System.Decimal? HighSchoolPercentile { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.HighSchoolStudentClassRank nullable property
        /// </summary>
        public System.Int32? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.HighSchoolGraduatingClassSize nullable property
        /// </summary>
        public System.Int32? HighSchoolGraduatingClassSize { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.WaitListedStudent nullable property
        /// </summary>
        public System.Boolean? WaitListedStudent { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradePointAverageDomain"/> model
        /// </summary>
        public Guid? RefGradePointAverageDomainId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
        /// </summary>
        public Guid? RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmittedStudent"/> model
        /// </summary>
        public Guid? RefAdmittedStudentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
