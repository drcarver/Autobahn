//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentApplicationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentApplicationModel Interface
     /// </summary>
    public partial interface IPsStudentApplicationModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.PostsecondaryApplicant nullable property
        /// </summary>
        System.Boolean? PostsecondaryApplicant { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.GradePointAverageCumulative nullable property
        /// </summary>
        System.Decimal? GradePointAverageCumulative { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.HighSchoolPercentile nullable property
        /// </summary>
        System.Decimal? HighSchoolPercentile { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.HighSchoolStudentClassRank nullable property
        /// </summary>
        System.Int32? HighSchoolStudentClassRank { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.HighSchoolGraduatingClassSize nullable property
        /// </summary>
        System.Int32? HighSchoolGraduatingClassSize { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.WaitListedStudent nullable property
        /// </summary>
        System.Boolean? WaitListedStudent { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradePointAverageDomain"/> model
        /// </summary>
        Guid? RefGradePointAverageDomainId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
        /// </summary>
        Guid? RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmittedStudent"/> model
        /// </summary>
        Guid? RefAdmittedStudentId { get; set; }

    }
}
