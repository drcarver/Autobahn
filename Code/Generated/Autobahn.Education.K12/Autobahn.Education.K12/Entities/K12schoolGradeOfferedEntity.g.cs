//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolGradeOfferedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolGradeOffered file
/// </summary>
[Table("K12schoolGradeOffered", Schema = "K12")]
public partial class K12schoolGradeOfferedEntity : EntityBase, IK12schoolGradeOffered
{
    #region "IK12schoolGradeOffered Properties"
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
