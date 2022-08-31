//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaPreKeligibilityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaPreKeligibility file
/// </summary>
[Table("K12leaPreKeligibility", Schema = "K12")]
public partial class K12leaPreKeligibilityEntity : EntityBase, IK12leaPreKeligibility
{
    #region "IK12leaPreKeligibility Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12lea")]
    public Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12leapreKeligibility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12leapreKeligibility")]
    public Guid K12leapreKeligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPrekindergartenEligibility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefPrekindergartenEligibility")]
    public Guid RefPrekindergartenEligibilityId { get; set; }

    #endregion
}
