//***************************************************************************
//* DomainName: Facilities
//* FileName:   BuildingSystemCategoryEntity.g.cs
//***************************************************************************

/// <summary>
/// The IBuildingSystemCategory file
/// </summary>
[Table("BuildingSystemCategory", Schema = "Facilities")]
public partial class BuildingSystemCategoryEntity : EntityBase, IBuildingSystemCategory
{
    #region "IBuildingSystemCategory Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IBuildingSystemComponent"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("BuildingSystemComponent")]
    public Guid BuildingSystemComponentId { get; set; }

    /// <summary>
    /// Building Air Distribution System Type
    /// <para>
    /// The primary means by which air is circulated, freshened, and exhausted.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20771">Building Air Distribution System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingAirDistributionSystemType")]
    public Guid? RefBuildingAirDistributionSystemTypeId { get; set; }

    /// <summary>
    /// Building Communications Management Component System Type
    /// <para>
    /// The type of system, interface, and management components for carrying voice, video, and data throughout a building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20772">Building Communications Management Component System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingCommMgmtComponentSystemType")]
    public Guid? RefBuildingCommMgmtComponentSystemTypeId { get; set; }

    /// <summary>
    /// Building Cooling Generation System Type
    /// <para>
    /// The type of mechanical systems and building designs used for cooling.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20775">Building Cooling Generation System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingCoolingGenerationSystemType")]
    public Guid? RefBuildingCoolingGenerationSystemTypeId { get; set; }

    /// <summary>
    /// Building Electrical System Type
    /// <para>
    /// The components and system required to distribute electricity throughout the building or site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20776">Building Electrical System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingElectricalSystemType")]
    public Guid? RefBuildingElectricalSystemTypeId { get; set; }

    /// <summary>
    /// Building Fire Protection System Type
    /// <para>
    /// The type of system that protects the facility against fire.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20779">Building Fire Protection System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingFireProtectionSystemType")]
    public Guid? RefBuildingFireProtectionSystemTypeId { get; set; }

    /// <summary>
    /// Building Heating Generation System Type
    /// <para>
    /// The method by which the heat is distributed and delivered throughout the room(s) or building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20780">Building Heating Generation System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingHeatingGenerationSystemType")]
    public Guid? RefBuildingHeatingGenerationSystemTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefBuildingHvacsystemType"/> model
    /// </summary>
    [ForeignKey("RefBuildingHvacsystemType")]
    public Guid? RefBuildingHvacsystemTypeId { get; set; }

    /// <summary>
    /// Building Mechanical Conveying System Type
    /// <para>
    /// Mechanical means for moving people and equipment within buildings.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20783">Building Mechanical Conveying System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingMechanicalConveyingSystemType")]
    public Guid? RefBuildingMechanicalConveyingSystemTypeId { get; set; }

    /// <summary>
    /// Building Mechanical System Type
    /// <para>
    /// The major manufactured systems required to operate a building.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20790">Building Mechanical System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingMechanicalSystemType")]
    public Guid? RefBuildingMechanicalSystemTypeId { get; set; }

    /// <summary>
    /// Building Plumbing System Type
    /// <para>
    /// The component of an on-site system for supplying, eliminating, and treating water.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20784">Building Plumbing System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingPlumbingSystemType")]
    public Guid? RefBuildingPlumbingSystemTypeId { get; set; }

    /// <summary>
    /// Building Security System Type
    /// <para>
    /// The type of system that protects the facility from intrusion.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20785">Building Security System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingSecuritySystemType")]
    public Guid? RefBuildingSecuritySystemTypeId { get; set; }

    /// <summary>
    /// Building System Type
    /// <para>
    /// The type of system that is installed in the building or site.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20792">Building System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingSystemType")]
    public Guid? RefBuildingSystemTypeId { get; set; }

    /// <summary>
    /// Building Technology Wiring System Type
    /// <para>
    /// The means through which voice, video, audio, and data information are conveyed.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20788">Building Technology Wiring System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingTechnologyWiringSystemType")]
    public Guid? RefBuildingTechnologyWiringSystemTypeId { get; set; }

    /// <summary>
    /// Building Vertical Transportation System Type
    /// <para>
    /// The type of system used to convey persons or freight between floors.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20793">Building Vertical Transportation System Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBuildingVerticalTransportationSystemType")]
    public Guid? RefBuildingVerticalTransportationSystemTypeId { get; set; }

    #endregion
}