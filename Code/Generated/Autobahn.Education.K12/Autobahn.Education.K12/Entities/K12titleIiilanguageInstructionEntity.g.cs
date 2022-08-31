//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12titleIiilanguageInstructionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12titleIiilanguageInstruction file
/// </summary>
[Table("K12titleIiilanguageInstruction", Schema = "K12")]
public partial class K12titleIiilanguageInstructionEntity : EntityBase, IK12titleIiilanguageInstruction
{
    #region "IK12titleIiilanguageInstruction Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiilanguageInstructionProgramType"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefTitleIiilanguageInstructionProgramType")]
    public Guid RefTitleIiilanguageInstructionProgramTypeId { get; set; }

    #endregion
}
