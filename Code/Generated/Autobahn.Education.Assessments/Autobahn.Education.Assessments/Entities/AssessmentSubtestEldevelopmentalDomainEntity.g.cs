//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestEldevelopmentalDomainEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSubtestEldevelopmentalDomain file
/// </summary>
[Table("AssessmentSubtestEldevelopmentalDomain", Schema = "Assessments")]
public partial class AssessmentSubtestEldevelopmentalDomainEntity : EntityBase, IAssessmentSubtestEldevelopmentalDomain
{
    #region "IAssessmentSubtestEldevelopmentalDomain Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSubtest"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentSubtest")]
    public Guid AssessmentSubtestId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAssessmentEldevelopmentalDomain"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefAssessmentEldevelopmentalDomain")]
    public Guid RefAssessmentEldevelopmentalDomainId { get; set; }

    #endregion
}
