//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaTitleIsupportServiceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaTitleIsupportService file
/// </summary>
[Table("K12leaTitleIsupportService", Schema = "K12")]
public partial class K12leaTitleIsupportServiceEntity : EntityBase, IK12leaTitleIsupportService
{
    #region "IK12leaTitleIsupportService Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12lea")]
    public Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12leaTitleIsupportService"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefK12leaTitleIsupportService")]
    public Guid RefK12leaTitleIsupportServiceId { get; set; }

    #endregion
}
