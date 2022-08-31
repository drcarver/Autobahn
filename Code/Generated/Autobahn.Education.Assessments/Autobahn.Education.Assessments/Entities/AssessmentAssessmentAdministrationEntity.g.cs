//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssessmentAdministrationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAssessmentAdministration file
/// </summary>
[Table("AssessmentAssessmentAdministration", Schema = "Assessments")]
public partial class AssessmentAssessmentAdministrationEntity : EntityBase, IAssessmentAssessmentAdministration
{
    #region "IAssessmentAssessmentAdministration Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentAdministration")]
    public Guid AssessmentAdministrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessment"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Assessment")]
    public Guid AssessmentId { get; set; }

    #endregion
}
