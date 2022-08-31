//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTelephoneEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationTelephone file
/// </summary>
[Table("OrganizationTelephone", Schema = "Common")]
public partial class OrganizationTelephoneEntity : EntityBase, IOrganizationTelephone
{
    #region "IOrganizationTelephone Properties"
    /// <summary>
    /// Do Not Publish Indicator
    /// <para>
    /// An indication that the record should not be published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
    /// </para>
    /// </summary>
    public Boolean? DoNotPublishIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Primary Telephone Number Indicator
    /// <para>
    /// An indication that the telephone number should be used as the principal number for a person or organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19219">Primary Telephone Number Indicator</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    public System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

    /// <summary>
    /// Institution Telephone Number Type
    /// <para>
    /// The type of communication number listed for an organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19167">Institution Telephone Number Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefInstitutionTelephoneType")]
    public Guid? RefInstitutionTelephoneTypeId { get; set; }

    /// <summary>
    /// Telephone Number Listed Status
    /// <para>
    /// An indication of whether a telephone number is listed under a directory assistance service.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20911">Telephone Number Listed Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefTelephoneNumberListedStatus")]
    public Guid? RefTelephoneNumberListedStatusId { get; set; }

    /// <summary>
    /// Telephone Number
    /// <para>
    /// The telephone number including the area code, and extension, if applicable.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19279">Telephone Number</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(24,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String TelephoneNumber { get; set; }

    #endregion
}