//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12lea file
/// </summary>
[Table("K12lea", Schema = "K12")]
public partial class K12leaEntity : EntityBase, IK12lea
{
    #region "IK12lea Properties"
    public Boolean? CharterSchoolIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterLeaStatus"/> model
    /// </summary>
    [ForeignKey("RefCharterLeaStatus")]
    public Guid? RefCharterLeaStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLeaImprovementStatus"/> model
    /// </summary>
    [ForeignKey("RefLeaImprovementStatus")]
    public Guid? RefLeaImprovementStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLeaType"/> model
    /// </summary>
    [ForeignKey("RefLeaType")]
    public Guid? RefLeaTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPublicSchoolChoiceStatus"/> model
    /// </summary>
    [ForeignKey("RefPublicSchoolChoiceStatus")]
    public Guid? RefPublicSchoolChoiceStatusId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(3,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SupervisoryUnionIdentificationNumber { get; set; }

    #endregion
}
