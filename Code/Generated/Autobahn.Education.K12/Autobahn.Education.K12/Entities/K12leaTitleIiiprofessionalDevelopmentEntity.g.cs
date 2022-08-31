//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaTitleIiiprofessionalDevelopmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaTitleIiiprofessionalDevelopment file
/// </summary>
[Table("K12leaTitleIiiprofessionalDevelopment", Schema = "K12")]
public partial class K12leaTitleIiiprofessionalDevelopmentEntity : EntityBase, IK12leaTitleIiiprofessionalDevelopment
{
    #region "IK12leaTitleIiiprofessionalDevelopment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12lea")]
    public Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12leatitleIiiprofessionalDevelopment"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12leatitleIiiprofessionalDevelopment")]
    public Guid K12leatitleIiiprofessionalDevelopmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiiprofessionalDevelopmentType"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefTitleIiiprofessionalDevelopmentType")]
    public Guid RefTitleIiiprofessionalDevelopmentTypeId { get; set; }

    #endregion
}
