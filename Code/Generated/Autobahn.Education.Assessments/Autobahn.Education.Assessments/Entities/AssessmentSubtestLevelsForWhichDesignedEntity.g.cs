//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestLevelsForWhichDesignedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestLevelsForWhichDesigned file
/// </summary>
[Table("AssessmentSubtestLevelsForWhichDesigned", Schema = "Assessments")]
public partial class AssessmentSubtestLevelsForWhichDesignedEntity : EntityBase, IAssessmentSubtestLevelsForWhichDesigned
{
    #region "IAssessmentSubtestLevelsForWhichDesigned Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubTest"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentSubTest")]
    public Guid AssessmentSubTestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGrade"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefGrade")]
    public Guid RefGradeId { get; set; }

    #endregion
}
