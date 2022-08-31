//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormSectionAssessmentAssetEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormSectionAssessmentAsset file
/// </summary>
[Table("AssessmentFormSectionAssessmentAsset", Schema = "Assessments")]
public partial class AssessmentFormSectionAssessmentAssetEntity : EntityBase, IAssessmentFormSectionAssessmentAsset
{
    #region "IAssessmentFormSectionAssessmentAsset Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAsset"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentAsset")]
    public Guid AssessmentAssetId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentFormSection")]
    public Guid AssessmentFormSectionId { get; set; }

    #endregion
}
