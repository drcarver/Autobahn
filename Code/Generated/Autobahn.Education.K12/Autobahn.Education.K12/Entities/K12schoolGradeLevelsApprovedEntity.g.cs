//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolGradeLevelsApprovedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolGradeLevelsApproved file
/// </summary>
[Table("K12schoolGradeLevelsApproved", Schema = "K12")]
public partial class K12schoolGradeLevelsApprovedEntity : EntityBase, IK12schoolGradeLevelsApproved
{
    #region "IK12schoolGradeLevelsApproved Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12school")]
    public Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefGradeLevel")]
    public Guid RefGradeLevelId { get; set; }

    #endregion
}
