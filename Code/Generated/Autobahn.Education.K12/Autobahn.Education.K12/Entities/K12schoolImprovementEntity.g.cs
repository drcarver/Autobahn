//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolImprovementEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12schoolImprovement file
/// </summary>
[Table("K12schoolImprovement", Schema = "K12")]
public partial class K12schoolImprovementEntity : EntityBase, IK12schoolImprovement
{
    #region "IK12schoolImprovement Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12school"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("K12school")]
    public Guid K12schoolId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementFunds"/> model
    /// </summary>
    [ForeignKey("RefSchoolImprovementFunds")]
    public Guid? RefSchoolImprovementFundsId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
    /// </summary>
    [ForeignKey("RefSchoolImprovementStatus")]
    public Guid? RefSchoolImprovementStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSigInterventionType"/> model
    /// </summary>
    [ForeignKey("RefSigInterventionType")]
    public Guid? RefSigInterventionTypeId { get; set; }

    public DateTime? SchoolImprovementExitDate { get; set; }

    #endregion
}
