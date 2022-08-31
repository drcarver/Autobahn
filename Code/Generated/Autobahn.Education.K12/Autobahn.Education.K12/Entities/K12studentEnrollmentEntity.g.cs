//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentEnrollmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentEnrollment file
/// </summary>
[Table("K12studentEnrollment", Schema = "K12")]
public partial class K12studentEnrollmentEntity : EntityBase, IK12studentEnrollment
{
    #region "IK12studentEnrollment Properties"
    public Boolean? DisplacedStudentStatus { get; set; }

    public DateTime? FirstEntryDateIntoUsschool { get; set; }

    public Boolean? NslpdirectCertificationIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDirectoryInformationBlockStatus"/> model
    /// </summary>
    [ForeignKey("RefDirectoryInformationBlockStatus")]
    public Guid? RefDirectoryInformationBlockStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEndOfTermStatus"/> model
    /// </summary>
    [ForeignKey("RefEndOfTermStatus")]
    public Guid? RefEndOfTermStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEnrollmentStatus"/> model
    /// </summary>
    [ForeignKey("RefEnrollmentStatus")]
    public Guid? RefEnrollmentStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEntryGradeLevel"/> model
    /// </summary>
    [ForeignKey("RefEntryGradeLevel")]
    public Guid? RefEntryGradeLevelId { get; set; }

    public Int32? RefEntryType { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitGradeLevel"/> model
    /// </summary>
    [ForeignKey("RefExitGradeLevel")]
    public Guid? RefExitGradeLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalStatus"/> model
    /// </summary>
    [ForeignKey("RefExitOrWithdrawalStatus")]
    public Guid? RefExitOrWithdrawalStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefExitOrWithdrawalType"/> model
    /// </summary>
    [ForeignKey("RefExitOrWithdrawalType")]
    public Guid? RefExitOrWithdrawalTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFoodServiceEligibility"/> model
    /// </summary>
    [ForeignKey("RefFoodServiceEligibility")]
    public Guid? RefFoodServiceEligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefNonPromotionReason"/> model
    /// </summary>
    [ForeignKey("RefNonPromotionReason")]
    public Guid? RefNonPromotionReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPromotionReason"/> model
    /// </summary>
    [ForeignKey("RefPromotionReason")]
    public Guid? RefPromotionReasonId { get; set; }

    public Int32? RefPublicSchoolResidence { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStudentEnrollmentAccessType"/> model
    /// </summary>
    [ForeignKey("RefStudentEnrollmentAccessType")]
    public Guid? RefStudentEnrollmentAccessTypeId { get; set; }

    #endregion
}
