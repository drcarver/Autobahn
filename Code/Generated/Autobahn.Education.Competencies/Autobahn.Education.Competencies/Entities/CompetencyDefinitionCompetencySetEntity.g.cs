//***************************************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefinitionCompetencySetEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencyDefinitionCompetencySet file
/// </summary>
[Table("CompetencyDefinitionCompetencySet", Schema = "Competencies")]
public partial class CompetencyDefinitionCompetencySetEntity : EntityBase, ICompetencyDefinitionCompetencySet
{
    #region "ICompetencyDefinitionCompetencySet Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CompetencyDefinition")]
    public Guid CompetencyDefinitionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencySet"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CompetencySet")]
    public Guid CompetencySetId { get; set; }

    #endregion
}
