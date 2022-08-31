//***************************************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentSectionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPsStudentSection file
/// </summary>
[Table("PsStudentSection", Schema = "Postsecondary")]
public partial class PsStudentSectionEntity : EntityBase, IPsStudentSection
{
    #region "IPsStudentSection Properties"
    /// <summary>
    /// Course Academic Grade
    /// <para>
    /// The final grade awarded for participation in the course. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19053">Course Academic Grade</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(15,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AcademicGrade { get; set; }

    /// <summary>
    /// Course Override School
    /// <para>
    /// The school where the credit was earned if different from the institution reporting. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19063">Course Override School</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(80,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CourseOverrideSchool { get; set; }

    /// <summary>
    /// Degree Applicability
    /// <para>
    /// An indication that the course is a part of a degree program. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19077">Degree Applicability</a>
    /// </para>
    /// </summary>
    public Boolean? DegreeApplicability { get; set; }

    /// <summary>
    /// Number of Credits Attempted
    /// <para>
    /// The number of credits that a student can earn for enrolling in and completing a given course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19199">Number of Credits Attempted</a>
    /// </para>
    /// </summary>
    public Decimal? NumberOfCreditsAttempted { get; set; }

    /// <summary>
    /// Number of Credits Earned
    /// <para>
    /// The number of credits an individual earns by the successful completion of a course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19200">Number of Credits Earned</a>
    /// </para>
    /// </summary>
    public Decimal? NumberOfCreditsEarned { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Course Quality Points Earned
    /// <para>
    /// The numerical value assigned to a letter grade to provide a basis of quantitative determination of an average. 
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19064">Course Quality Points Earned</a>
    /// </para>
    /// </summary>
    public Decimal? QualityPointsEarned { get; set; }

    /// <summary>
    /// Course Academic Grade Status Code
    /// <para>
    /// Additional information regarding the context of the given grade.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20265">Course Academic Grade Status Code</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCourseAcademicGradeStatusCode")]
    public Guid? RefCourseAcademicGradeStatusCodeId { get; set; }

    /// <summary>
    /// Course Repeat Code
    /// <para>
    /// Indicates that an academic course has been repeated by a student and how that repeat is to be computed in the student's academic grade average.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19065">Course Repeat Code</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCourseRepeatCode")]
    public Guid? RefCourseRepeatCodeId { get; set; }

    #endregion
}