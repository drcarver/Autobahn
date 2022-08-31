//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestCompetencyDefinitionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestCompetencyDefinition file
/// </summary>
[Table("AssessmentSubtestCompetencyDefinition", Schema = "Assessments")]
public partial class AssessmentSubtestCompetencyDefinitionEntity : EntityBase, IAssessmentSubtestCompetencyDefinition
{
    #region "IAssessmentSubtestCompetencyDefinition Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentSubtest")]
    public Guid AssessmentSubtestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CompetencyDefinition")]
    public Guid CompetencyDefinitionId { get; set; }

    #endregion
}
