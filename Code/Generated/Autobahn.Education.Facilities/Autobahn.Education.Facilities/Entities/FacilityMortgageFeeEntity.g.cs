//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityMortgageFeeEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityMortgageFee file
/// </summary>
[Table("FacilityMortgageFee", Schema = "Facilities")]
public partial class FacilityMortgageFeeEntity : EntityBase, IFacilityMortgageFee
{
    #region "IFacilityMortgageFee Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacilityMortgage"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("FacilityMortgage")]
    public Guid FacilityMortgageId { get; set; }

    /// <summary>
    /// Facility Financing Fee Type
    /// <para>
    /// The type of fee that one must pay when getting a mortgage.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20867">Facility Financing Fee Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefFacilityFinancingFeeType")]
    [Comment("The type of fee that one must pay when getting a mortgage.")]
    public Guid RefFacilityFinancingFeeTypeId { get; set; }

    #endregion
}
