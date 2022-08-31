//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefAgent file
/// </summary>
[Table("CredentialDefAgent", Schema = "Credentials")]
public partial class CredentialDefAgentEntity : EntityBase, ICredentialDefAgent
{
    #region "ICredentialDefAgent Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [ForeignKey("Organization")]
    public Guid? OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [ForeignKey("Person")]
    public Guid? PersonId { get; set; }

    /// <summary>
    /// Credential Definition Agent Role Type
    /// <para>
    /// The role that an organization or person has in relation to this Credential Definition based on terms defined by Credential Engine.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20895">Credential Definition Agent Role Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefCredentialDefAgentRoleType")]
    [Comment("The role that an organization or person has in relation to this Credential Definition based on terms defined by Credential Engine.")]
    public Guid? RefCredentialDefAgentRoleTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCtdlorganizationType"/> model
    /// </summary>
    [ForeignKey("RefCtdlorganizationType")]
    public Guid? RefCtdlorganizationTypeId { get; set; }

    #endregion
}
