//***************************************************************************
//* DomainName: Workforce
//* FileName:   WorkforceEmploymentQuarterlyDatumEntity.g.cs
//***************************************************************************

/// <summary>
/// The IWorkforceEmploymentQuarterlyDatum file
/// </summary>
[Table("WorkforceEmploymentQuarterlyDatum", Schema = "Workforce")]
public partial class WorkforceEmploymentQuarterlyDatumEntity : EntityBase, IWorkforceEmploymentQuarterlyDatum
{
    #region "IWorkforceEmploymentQuarterlyDatum Properties"
    public Decimal? EmployedInMultipleJobsCount { get; set; }

    public Boolean? MilitaryEnlistmentAfterExit { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
    /// </summary>
    [ForeignKey("RefEmployedAfterExit")]
    public Guid? RefEmployedAfterExitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
    /// </summary>
    [ForeignKey("RefEmployedWhileEnrolled")]
    public Guid? RefEmployedWhileEnrolledId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IWorkforceEmploymentQuarterlyData"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("WorkforceEmploymentQuarterlyData")]
    public Guid WorkforceEmploymentQuarterlyDataId { get; set; }

    #endregion
}
