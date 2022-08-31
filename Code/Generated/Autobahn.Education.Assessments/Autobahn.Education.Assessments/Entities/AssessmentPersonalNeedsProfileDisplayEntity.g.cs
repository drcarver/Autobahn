//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileDisplayEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfileDisplay file
/// </summary>
[Table("AssessmentPersonalNeedsProfileDisplay", Schema = "Assessments")]
public partial class AssessmentPersonalNeedsProfileDisplayEntity : EntityBase, IAssessmentPersonalNeedsProfileDisplay
{
    #region "IAssessmentPersonalNeedsProfileDisplay Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentPersonalNeedsProfile")]
    public Guid AssessmentPersonalNeedsProfileId { get; set; }

    #endregion
}
