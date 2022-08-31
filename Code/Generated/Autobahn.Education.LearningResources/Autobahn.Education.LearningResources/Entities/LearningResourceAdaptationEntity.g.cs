//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceAdaptationEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourceAdaptation file
/// </summary>
[Table("LearningResourceAdaptation", Schema = "LearningResources")]
public partial class LearningResourceAdaptationEntity : EntityBase, ILearningResourceAdaptation
{
    #region "ILearningResourceAdaptation Properties"
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String AdaptationUrl { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("LearningResource")]
    public Guid LearningResourceId { get; set; }

    #endregion
}
