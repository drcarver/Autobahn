//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityDesignEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityDesign file
/// </summary>
public partial class FacilityDesignModel : AutobahnBaseModel, IFacilityDesign
{
    #region "IFacilityDesign Properties"
    /// <summary>
    /// Building Architect Name
    /// <para>
    /// The name of the architect of record for the building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20815">Building Architect Name</a>
    /// </para>
    /// </summary>
    public System.String BuildingArchitectName { get; set; }

    /// <summary>
    /// Building Architectural Firm Name
    /// <para>
    /// The name of the architectural firm responsible for the building design.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20816">Building Architectural Firm Name</a>
    /// </para>
    /// </summary>
    public System.String BuildingArchitecturalFirmName { get; set; }

    /// <summary>
    /// Building Date of Certificate of Occupancy
    /// <para>
    /// The month, day and year in which a certificate of occupancy was granted by the appropriate local authority.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20861">Building Date of Certificate of Occupancy</a>
    /// </para>
    /// </summary>
    public DateTime? BuildingDateOfCertificateOfOccupancy { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Building Design Type
    /// <para>
    /// The primary design or purpose of a building, as determined by its physical layout and built-in systems and equipment, regardless of its current use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20797">Building Design Type</a>
    /// </para>
    /// </summary>
    public Guid? RefBuildingDesignTypeId { get; set; }

    /// <summary>
    /// Building Environmental or Energy Performance Rating Category
    /// <para>
    /// The primary groupings that rating organizations use to evaluate environmental sustainability and energy use.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20800">Building Environmental or Energy Performance Rating Category</a>
    /// </para>
    /// </summary>
    public Guid? RefBuildingEnvOrEnergyPerformanceRatingCatId { get; set; }

    #endregion
}
