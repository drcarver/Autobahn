//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationOperationalStatusEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationOperationalStatus file
/// </summary>
[Table("OrganizationOperationalStatus", Schema = "Common")]
public partial class OrganizationOperationalStatusEntity : EntityBase, IOrganizationOperationalStatus
{
    #region "IOrganizationOperationalStatus Properties"
    /// <summary>
    /// Operation Date
    /// <para>
    /// The year, month and day on which a program or center began operation.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19350">Operation Date</a>
    /// </para>
    /// </summary>
    public DateTime? OperationalStatusEffectiveDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Local Education Agency Operational Status
    /// <para>
    /// The classification of the operational condition of a local education agency (LEA) at the start of the school year.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19174">Local Education Agency Operational Status</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefOperationalStatus")]
    public Guid RefOperationalStatusId { get; set; }

    #endregion
}
