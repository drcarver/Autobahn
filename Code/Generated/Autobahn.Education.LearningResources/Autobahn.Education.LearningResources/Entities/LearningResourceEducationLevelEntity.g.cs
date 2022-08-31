//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceEducationLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourceEducationLevel file
/// </summary>
[Table("LearningResourceEducationLevel", Schema = "LearningResources")]
public partial class LearningResourceEducationLevelEntity : EntityBase, ILearningResourceEducationLevel
{
    #region "ILearningResourceEducationLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("LearningResource")]
    public Guid LearningResourceId { get; set; }

    /// <summary>
    /// Learning Resource Education Level�
    /// <para>
    /// The education level, grade level or primary instructional level at which a Learning Resource is intended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20212">Learning Resource Education Level�</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefEducationLevel")]
    public Guid RefEducationLevelId { get; set; }

    #endregion
}
