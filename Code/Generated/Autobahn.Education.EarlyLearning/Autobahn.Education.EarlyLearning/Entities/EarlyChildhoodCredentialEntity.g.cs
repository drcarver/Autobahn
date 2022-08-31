//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodCredentialEntity.g.cs
//***************************************************************************

/// <summary>
/// The IEarlyChildhoodCredential file
/// </summary>
[Table("EarlyChildhoodCredential", Schema = "EarlyLearning")]
public partial class EarlyChildhoodCredentialEntity : EntityBase, IEarlyChildhoodCredential
{
    #region "IEarlyChildhoodCredential Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonCredential"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonCredential")]
    public Guid PersonCredentialId { get; set; }

    /// <summary>
    /// Early Childhood Credential
    /// <para>
    /// The credential related to early childhood education or development held by a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19344">Early Childhood Credential</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefEarlyChildhoodCredential")]
    public Guid RefEarlyChildhoodCredentialId { get; set; }

    #endregion
}
