//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentAssetEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormAssessmentAsset file
/// </summary>
[Table("AssessmentFormAssessmentAsset", Schema = "Assessments")]
public partial class AssessmentFormAssessmentAssetEntity : EntityBase, IAssessmentFormAssessmentAsset
{
    #region "IAssessmentFormAssessmentAsset Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentAsset")]
    public Guid AssessmentAssetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentForm")]
    public Guid AssessmentFormId { get; set; }

    #endregion
}
