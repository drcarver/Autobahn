//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentFormSectionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentFormAssessmentFormSection file
/// </summary>
[Table("AssessmentFormAssessmentFormSection", Schema = "Assessments")]
public partial class AssessmentFormAssessmentFormSectionEntity : EntityBase, IAssessmentFormAssessmentFormSection
{
    #region "IAssessmentFormAssessmentFormSection Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentForm"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentForm")]
    public Guid AssessmentFormId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentFormSection"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentFormSection")]
    public Guid AssessmentFormSectionId { get; set; }

    public Int32? SequenceNumber { get; set; }

    #endregion
}
