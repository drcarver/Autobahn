//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12school file
/// </summary>
[Table("K12school", Schema = "K12")]
public partial class K12schoolEntity : EntityBase, IK12school
{
    #region "IK12school Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AccreditationAgencyName { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(9,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CharterSchoolApprovalYear { get; set; }

    public DateTime? CharterSchoolContractApprovalDate { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String CharterSchoolContractIdNumber { get; set; }

    public DateTime? CharterSchoolContractRenewalDate { get; set; }

    public Boolean? CharterSchoolIndicator { get; set; }

    public Boolean? CharterSchoolOpenEnrollmentIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12charterSchoolAuthorizerAgency"/> model
    /// </summary>
    [ForeignKey("K12charterSchoolAuthorizerAgency")]
    public Guid? K12charterSchoolAuthorizerAgencyId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12charterSchoolManagementOrganization"/> model
    /// </summary>
    [ForeignKey("K12charterSchoolManagementOrganization")]
    public Guid? K12charterSchoolManagementOrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
    /// </summary>
    [ForeignKey("RefAdministrativeFundingControl")]
    public Guid? RefAdministrativeFundingControlId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterSchoolType"/> model
    /// </summary>
    [ForeignKey("RefCharterSchoolType")]
    public Guid? RefCharterSchoolTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
    /// </summary>
    [ForeignKey("RefIncreasedLearningTimeType")]
    public Guid? RefIncreasedLearningTimeTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolLevel"/> model
    /// </summary>
    [ForeignKey("RefSchoolLevel")]
    public Guid? RefSchoolLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolType"/> model
    /// </summary>
    [ForeignKey("RefSchoolType")]
    public Guid? RefSchoolTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStatePovertyDesignation"/> model
    /// </summary>
    [ForeignKey("RefStatePovertyDesignation")]
    public Guid? RefStatePovertyDesignationId { get; set; }

    #endregion
}
