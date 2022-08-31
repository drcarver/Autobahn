//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministrationOrganizationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAdministrationOrganization file
/// </summary>
[Table("AssessmentAdministrationOrganization", Schema = "Assessments")]
public partial class AssessmentAdministrationOrganizationEntity : EntityBase, IAssessmentAdministrationOrganization
{
    #region "IAssessmentAdministrationOrganization Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAdministration"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentAdministration")]
    public Guid AssessmentAdministrationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    #endregion
}
