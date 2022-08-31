//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialDefAgentCredentialEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialDefAgentCredential file
/// </summary>
[Table("CredentialDefAgentCredential", Schema = "Credentials")]
public partial class CredentialDefAgentCredentialEntity : EntityBase, ICredentialDefAgentCredential
{
    #region "ICredentialDefAgentCredential Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefAgent"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CredentialDefAgent")]
    public Guid CredentialDefAgentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefinition"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CredentialDefinition")]
    public Guid CredentialDefinitionId { get; set; }

    #endregion
}
