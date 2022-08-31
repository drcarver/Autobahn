//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSessionStaffRoleEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentSessionStaffRole file
/// </summary>
[Table("AssessmentSessionStaffRole", Schema = "Assessments")]
public partial class AssessmentSessionStaffRoleEntity : EntityBase, IAssessmentSessionStaffRole
{
    #region "IAssessmentSessionStaffRole Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentParticipantSession"/> model
    /// </summary>
    [ForeignKey("AssessmentParticipantSession")]
    public Guid? AssessmentParticipantSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentSession"/> model
    /// </summary>
    [ForeignKey("AssessmentSession")]
    public Guid? AssessmentSessionId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Assessment Session Staff Role Type
    /// <para>
    /// The type of role served related to the administration of an assessment session.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20179">Assessment Session Staff Role Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAssessmentSessionStaffRoleType")]
    public Guid? RefAssessmentSessionStaffRoleTypeId { get; set; }

    #endregion
}
