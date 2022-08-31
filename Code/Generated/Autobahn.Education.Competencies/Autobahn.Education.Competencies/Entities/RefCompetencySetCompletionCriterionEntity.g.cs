//***************************************************************************
//* DomainName: Competencies
//* FileName:   RefCompetencySetCompletionCriterionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefCompetencySetCompletionCriterion file
/// </summary>
public partial class RefCompetencySetCompletionCriterionEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefCompetencySetCompletionCriterion Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCompetencySetCompletionCriteria"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefCompetencySetCompletionCriteria")]
    public Guid RefCompetencySetCompletionCriteriaId { get; set; }

    #endregion
}
