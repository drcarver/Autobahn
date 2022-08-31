//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationProgramTypeEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationProgramType file
/// </summary>
[Table("OrganizationProgramType", Schema = "Common")]
public partial class OrganizationProgramTypeEntity : EntityBase, IOrganizationProgramType
{
    #region "IOrganizationProgramType Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Program Type
    /// <para>
    /// The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19225">Program Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefProgramType")]
    [Comment("The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.")]
    public Guid RefProgramTypeId { get; set; }

    #endregion
}
