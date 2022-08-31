//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileScreenEnhancementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfileScreenEnhancement file
/// </summary>
[Table("AssessmentPersonalNeedsProfileScreenEnhancement", Schema = "Assessments")]
public partial class AssessmentPersonalNeedsProfileScreenEnhancementEntity : EntityBase, IAssessmentPersonalNeedsProfileScreenEnhancement
{
    #region "IAssessmentPersonalNeedsProfileScreenEnhancement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentPersonalNeedsProfile")]
    public Guid AssessmentPersonalNeedsProfileId { get; set; }

    #endregion
}
