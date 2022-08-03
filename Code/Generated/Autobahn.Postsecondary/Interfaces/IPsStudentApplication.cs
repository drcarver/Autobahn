//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IPsStudentApplication.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IPsStudentApplication
     /// </summary>
    public partial interface IPsStudentApplication
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

        /// <summary>
        /// Defines the PsStudentApplication.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PsStudentApplication.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
