//***************************************************************************
//* DomainName: Competencies
//* FileName:   CompetencySetRubricEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencySetRubric file
/// </summary>
[Table("CompetencySetRubric", Schema = "Competencies")]
public partial class CompetencySetRubricEntity : EntityBase, ICompetencySetRubric
{
    #region "ICompetencySetRubric Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CompetencySet")]
    public Guid CompetencySetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRubric"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Rubric")]
    public Guid RubricId { get; set; }

    #endregion
}
