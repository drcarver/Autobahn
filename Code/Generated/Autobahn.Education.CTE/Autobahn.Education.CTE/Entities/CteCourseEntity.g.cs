//***************************************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   CteCourseEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICteCourse file
/// </summary>
[Table("CteCourse", Schema = "CTE")]
public partial class CteCourseEntity : EntityBase, ICteCourse
{
    #region "ICteCourse Properties"
    /// <summary>
    /// Available Carnegie Unit Credit
    /// <para>
    /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19030">Available Carnegie Unit Credit</a>
    /// </para>
    /// </summary>
    public Decimal? AvailableCarnegieUnitCredit { get; set; }

    /// <summary>
    /// Core Academic Course
    /// <para>
    /// The course meets the state definition of a core academic course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19509">Core Academic Course</a>
    /// </para>
    /// </summary>
    public Boolean? CoreAcademicCourse { get; set; }

    /// <summary>
    /// Course Aligned with Standards
    /// <para>
    /// An indication whether a course is aligned with the established standards of a curriculum framework.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19013">Course Aligned with Standards</a>
    /// </para>
    /// </summary>
    public Boolean? CourseAlignedWithStandards { get; set; }

    /// <summary>
    /// Course Department Name
    /// <para>
    /// Department with jurisdiction over this course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20525">Course Department Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CourseDepartmentName { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Course")]
    public Guid CourseId { get; set; }

    /// <summary>
    /// High School Course Requirement
    /// <para>
    /// An indication that this course credit is required for a high school diploma.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19137">High School Course Requirement</a>
    /// </para>
    /// </summary>
    public Boolean? HighSchoolCourseRequirement { get; set; }

    /// <summary>
    /// Additional Credit Type
    /// <para>
    /// The type of credits or units of value available for the completion of a course in addition to Carnegie Units.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19589">Additional Credit Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAdditionalCreditType")]
    public Guid? RefAdditionalCreditTypeId { get; set; }

    /// <summary>
    /// Career Cluster
    /// <para>
    /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCareerCluster")]
    public Guid? RefCareerClusterId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCourseGpaapplicability"/> model
    /// </summary>
    [ForeignKey("RefCourseGpaapplicability")]
    public Guid? RefCourseGpaapplicabilityId { get; set; }

    /// <summary>
    /// Credit Unit Type
    /// <para>
    /// The type of credits or units of value awarded for the completion of a course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19072">Credit Unit Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCreditTypeEarned")]
    public Guid? RefCreditTypeEarnedId { get; set; }

    /// <summary>
    /// Curriculum Framework Type
    /// <para>
    /// An indication of the standard curriculum used for this course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19688">Curriculum Framework Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCurriculumFrameworkType")]
    public Guid? RefCurriculumFrameworkTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseLevel"/> model
    /// </summary>
    [ForeignKey("RefScedcourseLevel")]
    public Guid? RefScedcourseLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
    /// </summary>
    [ForeignKey("RefScedcourseSubjectArea")]
    public Guid? RefScedcourseSubjectAreaId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(5,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ScedcourseCode { get; set; }

    #endregion
}
