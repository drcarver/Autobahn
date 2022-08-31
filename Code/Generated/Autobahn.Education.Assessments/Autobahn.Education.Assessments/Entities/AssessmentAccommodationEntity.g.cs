//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAccommodationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentAccommodation file
/// </summary>
[Table("AssessmentAccommodation", Schema = "Assessments")]
public partial class AssessmentAccommodationEntity : EntityBase, IAssessmentAccommodation
{
    #region "IAssessmentAccommodation Properties"
    /// <summary>
    /// Accommodation Other Description
    /// <para>
    /// The description of the accommodation when 'Accommodation Type' is set to 'Other'.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20116">Accommodation Other Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String OtherDescription { get; set; }

    /// <summary>
    /// Accommodation Type
    /// <para>
    /// The specific accommodation necessary for assessment or instruction.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19376">Accommodation Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAccommodationType")]
    public Guid? RefAccommodationTypeId { get; set; }

    /// <summary>
    /// Assessment Accommodation Category
    /// <para>
    /// A category of accommodations needed for a given assessment.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19374">Assessment Accommodation Category</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAssessmentAccommodationCategory")]
    public Guid? RefAssessmentAccommodationCategoryId { get; set; }

    #endregion
}
