//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialCriteriaCourseEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialCriteriaCourse file
/// </summary>
[Table("CredentialCriteriaCourse", Schema = "Credentials")]
public partial class CredentialCriteriaCourseEntity : EntityBase, ICredentialCriteriaCourse
{
    #region "ICredentialCriteriaCourse Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Course")]
    public Guid CourseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefCriteria"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CredentialDefCriteria")]
    public Guid CredentialDefCriteriaId { get; set; }

    #endregion
}
