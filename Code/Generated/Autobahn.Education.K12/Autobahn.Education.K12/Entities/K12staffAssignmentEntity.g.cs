//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12staffAssignmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12staffAssignment file
/// </summary>
[Table("K12staffAssignment", Schema = "K12")]
public partial class K12staffAssignmentEntity : EntityBase, IK12staffAssignment
{
    #region "IK12staffAssignment Properties"
    public Decimal? ContributionPercentage { get; set; }

    public Decimal? FullTimeEquivalency { get; set; }

    public Boolean? HighlyQualifiedTeacherIndicator { get; set; }

    public Boolean? ItinerantTeacher { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    public Boolean? PrimaryAssignment { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefClassroomPositionType"/> model
    /// </summary>
    [ForeignKey("RefClassroomPositionType")]
    public Guid? RefClassroomPositionTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEdfactsTeacherInexperiencedStatus"/> model
    /// </summary>
    [ForeignKey("RefEdfactsTeacherInexperiencedStatus")]
    public Guid? RefEdfactsTeacherInexperiencedStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmergencyOrProvisionalCredentialStatus"/> model
    /// </summary>
    [ForeignKey("RefEmergencyOrProvisionalCredentialStatus")]
    public Guid? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12staffClassification"/> model
    /// </summary>
    [ForeignKey("RefK12staffClassification")]
    public Guid? RefK12staffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMepStaffCategory"/> model
    /// </summary>
    [ForeignKey("RefMepStaffCategory")]
    public Guid? RefMepStaffCategoryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOutOfFieldStatus"/> model
    /// </summary>
    [ForeignKey("RefOutOfFieldStatus")]
    public Guid? RefOutOfFieldStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProfessionalEducationJobClassification"/> model
    /// </summary>
    [ForeignKey("RefProfessionalEducationJobClassification")]
    public Guid? RefProfessionalEducationJobClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSpecialEducationAgeGroupTaught"/> model
    /// </summary>
    [ForeignKey("RefSpecialEducationAgeGroupTaught")]
    public Guid? RefSpecialEducationAgeGroupTaughtId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
    /// </summary>
    [ForeignKey("RefSpecialEducationStaffCategory")]
    public Guid? RefSpecialEducationStaffCategoryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTeachingAssignmentRole"/> model
    /// </summary>
    [ForeignKey("RefTeachingAssignmentRole")]
    public Guid? RefTeachingAssignmentRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIprogramStaffCategory"/> model
    /// </summary>
    [ForeignKey("RefTitleIprogramStaffCategory")]
    public Guid? RefTitleIprogramStaffCategoryId { get; set; }

    public Boolean? SpecialEducationParaprofessional { get; set; }

    public Boolean? SpecialEducationRelatedServicesPersonnel { get; set; }

    public Boolean? SpecialEducationTeacher { get; set; }

    public Boolean? TeacherOfRecord { get; set; }

    #endregion
}
