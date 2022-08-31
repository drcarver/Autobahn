//***************************************************************************
//* DomainName: Assessments
//* FileName:   RefLearnerActivityMaximumTimeAllowedUnitEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefLearnerActivityMaximumTimeAllowedUnit file
/// </summary>
[Table("RefLearnerActivityMaximumTimeAllowedUnit", Schema = "Assessments")]
public partial class RefLearnerActivityMaximumTimeAllowedUnitEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefLearnerActivityMaximumTimeAllowedUnit Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLearnerActivityMaximumTimeAllowedUnits"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefLearnerActivityMaximumTimeAllowedUnits")]
    public Guid RefLearnerActivityMaximumTimeAllowedUnitsId { get; set; }

    #endregion
}
