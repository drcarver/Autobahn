//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationLocationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationLocation file
/// </summary>
[Table("OrganizationLocation", Schema = "Common")]
public partial class OrganizationLocationEntity : EntityBase, IOrganizationLocation
{
    #region "IOrganizationLocation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Location")]
    public Guid LocationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Address Type for Organization
    /// <para>
    /// The type of address listed for an organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19644">Address Type for Organization</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefOrganizationLocationType")]
    [Comment("The type of address listed for an organization.")]
    public Guid? RefOrganizationLocationTypeId { get; set; }

    #endregion
}
