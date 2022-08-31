//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultRubricCriterionResultEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentResultRubricCriterionResult file
/// </summary>
[Table("AssessmentResultRubricCriterionResult", Schema = "Assessments")]
public partial class AssessmentResultRubricCriterionResultEntity : EntityBase, IAssessmentResultRubricCriterionResult
{
    #region "IAssessmentResultRubricCriterionResult Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentResult")]
    public Guid AssessmentResultId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubricCriterionLevel"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RubricCriterionLevel")]
    public Guid RubricCriterionLevelId { get; set; }

    #endregion
}
