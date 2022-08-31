//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12staffEmploymentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12staffEmployment file
/// </summary>
[Table("K12staffEmployment", Schema = "K12")]
public partial class K12staffEmploymentEntity : EntityBase, IK12staffEmployment
{
    #region "IK12staffEmployment Properties"
    public Decimal? ContractDaysOfServicePerYear { get; set; }

    public Boolean? MepPersonnelIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
    /// </summary>
    [ForeignKey("RefEmploymentStatus")]
    public Guid? RefEmploymentStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12staffClassification"/> model
    /// </summary>
    [ForeignKey("RefK12staffClassification")]
    public Guid? RefK12staffClassificationId { get; set; }

    public Boolean? SalaryForTeachingAssignmentOnlyIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("StaffEmployment")]
    public Guid StaffEmploymentId { get; set; }

    public Boolean? TitleItargetedAssistanceStaffFunded { get; set; }

    #endregion
}
