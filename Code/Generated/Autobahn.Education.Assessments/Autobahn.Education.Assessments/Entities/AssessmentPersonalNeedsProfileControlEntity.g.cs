//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileControlEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentPersonalNeedsProfileControl file
/// </summary>
[Table("AssessmentPersonalNeedsProfileControl", Schema = "Assessments")]
public partial class AssessmentPersonalNeedsProfileControlEntity : EntityBase, IAssessmentPersonalNeedsProfileControl
{
    #region "IAssessmentPersonalNeedsProfileControl Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPersonalNeedsProfile"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentPersonalNeedsProfile")]
    public Guid AssessmentPersonalNeedsProfileId { get; set; }

    #endregion
}
