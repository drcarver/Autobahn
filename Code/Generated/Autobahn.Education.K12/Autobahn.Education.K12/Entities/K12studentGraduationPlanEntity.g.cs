//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentGraduationPlanEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentGraduationPlan file
/// </summary>
[Table("K12studentGraduationPlan", Schema = "K12")]
public partial class K12studentGraduationPlanEntity : EntityBase, IK12studentGraduationPlan
{
    #region "IK12studentGraduationPlan Properties"
    public Decimal? CreditsRequired { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12course"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12course")]
    public Guid K12courseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevelWhenCourseTaken"/> model
    /// </summary>
    [ForeignKey("RefGradeLevelWhenCourseTaken")]
    public Guid? RefGradeLevelWhenCourseTakenId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefScedcourseSubjectArea"/> model
    /// </summary>
    [ForeignKey("RefScedcourseSubjectArea")]
    public Guid? RefScedcourseSubjectAreaId { get; set; }

    #endregion
}
