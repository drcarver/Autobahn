//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationRelationshipEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationRelationship file
/// </summary>
[Table("OrganizationRelationship", Schema = "Common")]
public partial class OrganizationRelationshipEntity : EntityBase, IOrganizationRelationship
{
    #region "IOrganizationRelationship Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IParentOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("ParentOrganization")]
    public Guid ParentOrganizationId { get; set; }

    /// <summary>
    /// Organization Relationship Type
    /// <para>
    /// The nature of one organization's relationship to another.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20886">Organization Relationship Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefOrganizationRelationship")]
    [Comment("The nature of one organization's relationship to another.")]
    public Guid? RefOrganizationRelationshipId { get; set; }

    #endregion
}
