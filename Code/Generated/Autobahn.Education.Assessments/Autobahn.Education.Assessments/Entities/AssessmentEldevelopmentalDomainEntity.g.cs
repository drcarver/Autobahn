//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentEldevelopmentalDomainEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentEldevelopmentalDomain file
/// </summary>
[Table("AssessmentEldevelopmentalDomain", Schema = "Assessments")]
public partial class AssessmentEldevelopmentalDomainEntity : EntityBase, IAssessmentEldevelopmentalDomain
{
    #region "IAssessmentEldevelopmentalDomain Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Assessment")]
    public Guid AssessmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefAssessmentEldevelopmentalDomain")]
    public Guid RefAssessmentEldevelopmentalDomainId { get; set; }

    #endregion
}
