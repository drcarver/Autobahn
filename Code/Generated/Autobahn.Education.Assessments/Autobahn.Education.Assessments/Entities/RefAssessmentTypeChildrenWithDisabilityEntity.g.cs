//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefAssessmentTypeChildrenWithDisabilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefAssessmentTypeChildrenWithDisability file
/// </summary>
public partial class RefAssessmentTypeChildrenWithDisabilityEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefAssessmentTypeChildrenWithDisability Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentTypeChildrenWithDisabilities"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefAssessmentTypeChildrenWithDisabilities")]
    public Guid RefAssessmentTypeChildrenWithDisabilitiesId { get; set; }

    #endregion
}
