//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentNeedNumberOfBrailleDotEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefAssessmentNeedNumberOfBrailleDot file
/// </summary>
public partial class RefAssessmentNeedNumberOfBrailleDotEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefAssessmentNeedNumberOfBrailleDot Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentNeedNumberOfBrailleDots"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefAssessmentNeedNumberOfBrailleDots")]
    public Guid RefAssessmentNeedNumberOfBrailleDotsId { get; set; }

    #endregion
}
