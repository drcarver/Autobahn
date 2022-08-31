//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediumEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourcePhysicalMedium file
/// </summary>
[Table("LearningResourcePhysicalMedium", Schema = "LearningResources")]
public partial class LearningResourcePhysicalMediumEntity : EntityBase, ILearningResourcePhysicalMedium
{
    #region "ILearningResourcePhysicalMedium Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("LearningResource")]
    public Guid LearningResourceId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResourcePhysicalMedia"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("LearningResourcePhysicalMedia")]
    public Guid LearningResourcePhysicalMediaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLearningResourcePhysicalMediaType"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefLearningResourcePhysicalMediaType")]
    public Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

    #endregion
}
