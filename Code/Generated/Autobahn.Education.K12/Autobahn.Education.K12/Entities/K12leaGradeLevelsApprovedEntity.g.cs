//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaGradeLevelsApprovedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaGradeLevelsApproved file
/// </summary>
[Table("K12leaGradeLevelsApproved", Schema = "K12")]
public partial class K12leaGradeLevelsApprovedEntity : EntityBase, IK12leaGradeLevelsApproved
{
    #region "IK12leaGradeLevelsApproved Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12lea")]
    public Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefGradeLevel")]
    public Guid RefGradeLevelId { get; set; }

    #endregion
}
