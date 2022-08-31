//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestAssessmentItemEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestAssessmentItem file
/// </summary>
[Table("AssessmentSubtestAssessmentItem", Schema = "Assessments")]
public partial class AssessmentSubtestAssessmentItemEntity : EntityBase, IAssessmentSubtestAssessmentItem
{
    #region "IAssessmentSubtestAssessmentItem Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentItem")]
    public Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentSubtest")]
    public Guid AssessmentSubtestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtestItem"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentSubtestItem")]
    public Guid AssessmentSubtestItemId { get; set; }

    public Decimal? ItemWeightCorrect { get; set; }

    public Decimal? ItemWeightIncorrect { get; set; }

    public Decimal? ItemWeightNotAttempted { get; set; }

    #endregion
}
