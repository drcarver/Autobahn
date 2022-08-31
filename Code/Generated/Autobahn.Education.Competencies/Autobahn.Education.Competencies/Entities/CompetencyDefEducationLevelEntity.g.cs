//***************************************************************************
//* DomainName: Competencies
//* FileName:   CompetencyDefEducationLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICompetencyDefEducationLevel file
/// </summary>
[Table("CompetencyDefEducationLevel", Schema = "Competencies")]
public partial class CompetencyDefEducationLevelEntity : EntityBase, ICompetencyDefEducationLevel
{
    #region "ICompetencyDefEducationLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICompetencyDefinition"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CompetencyDefinition")]
    public Guid CompetencyDefinitionId { get; set; }

    /// <summary>
    /// Competency Definition Education Level
    /// <para>
    /// The education level, grade level or primary instructional level at which a Competency Definition is intended.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19701">Competency Definition Education Level</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefEducationLevel")]
    public Guid RefEducationLevelId { get; set; }

    #endregion
}