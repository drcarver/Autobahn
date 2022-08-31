//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityLeaseEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityLease file
/// </summary>
[Table("FacilityLease", Schema = "Facilities")]
public partial class FacilityLeaseEntity : EntityBase, IFacilityLease
{
    #region "IFacilityLease Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Facility Lease Amount
    /// <para>
    /// The amount of money the school must pay to rent the facility that it is in.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20868">Facility Lease Amount</a>
    /// </para>
    /// </summary>
    public Decimal? FacilityLeaseAmount { get; set; }

    /// <summary>
    /// Facility Lease Amount Category
    /// <para>
    /// The category of payment that a school must pay to rent the facility that it is in.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20869">Facility Lease Amount Category</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityLeaseAmountCategory")]
    public Guid? RefFacilityLeaseAmountCategoryId { get; set; }

    /// <summary>
    /// Facility Lease Type
    /// <para>
    /// The type of agreement that allows the use and possession of a school, building, or other facility from a third party in return for a regularly scheduled installment payment over an agreed-upon period.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20870">Facility Lease Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefFacilityLeaseType")]
    public Guid? RefFacilityLeaseTypeId { get; set; }

    #endregion
}
