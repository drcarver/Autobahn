//***************************************************************************
//* DomainName: Facilities
//* FileName:   FacilityLocationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityLocation file
/// </summary>
[Table("FacilityLocation", Schema = "Facilities")]
public partial class FacilityLocationEntity : EntityBase, IFacilityLocation
{
    #region "IFacilityLocation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Facility")]
    public Guid FacilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILocation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Location")]
    public Guid LocationId { get; set; }

    #endregion
}
