//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentResultPerformanceLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentResultPerformanceLevel file
/// </summary>
[Table("AssessmentResultPerformanceLevel", Schema = "Assessments")]
public partial class AssessmentResultPerformanceLevelEntity : EntityBase, IAssessmentResultPerformanceLevel
{
    #region "IAssessmentResultPerformanceLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentPerformanceLevel"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentPerformanceLevel")]
    public Guid AssessmentPerformanceLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentResult"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentResult")]
    public Guid AssessmentResultId { get; set; }

    #endregion
}
