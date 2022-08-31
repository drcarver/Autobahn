//***************************************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceMediaFeatureEntity.g.cs
//***************************************************************************

/// <summary>
/// The ILearningResourceMediaFeature file
/// </summary>
[Table("LearningResourceMediaFeature", Schema = "LearningResources")]
public partial class LearningResourceMediaFeatureEntity : EntityBase, ILearningResourceMediaFeature
{
    #region "ILearningResourceMediaFeature Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ILearningResource"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("LearningResource")]
    public Guid LearningResourceId { get; set; }

    /// <summary>
    /// Learning Resource Media Feature Type
    /// <para>
    /// Accessible content features included with the learning resource.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20368">Learning Resource Media Feature Type</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefLearningResourceMediaFeatureType")]
    public Guid RefLearningResourceMediaFeatureTypeId { get; set; }

    #endregion
}