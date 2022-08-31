//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolCorrectiveActionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolCorrectiveAction file
/// </summary>
[Table("K12schoolCorrectiveAction", Schema = "K12")]
public partial class K12schoolCorrectiveActionEntity : EntityBase, IK12schoolCorrectiveAction
{
    #region "IK12schoolCorrectiveAction Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12school")]
    public Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCorrectiveActionType"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefCorrectiveActionType")]
    public Guid RefCorrectiveActionTypeId { get; set; }

    #endregion
}
