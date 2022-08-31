//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemCharacteristicEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentItemCharacteristic file
/// </summary>
[Table("AssessmentItemCharacteristic", Schema = "Assessments")]
public partial class AssessmentItemCharacteristicEntity : EntityBase, IAssessmentItemCharacteristic
{
    #region "IAssessmentItemCharacteristic Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentItem"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentItem")]
    public Guid AssessmentItemId { get; set; }

    /// <summary>
    /// Assessment Item Characteristic Type
    /// <para>
    /// The type of psychometric measure provided for assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19384">Assessment Item Characteristic Type</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefAssessmentItemCharacteristicType")]
    public Guid? RefAssessmentItemCharacteristicTypeId { get; set; }

    /// <summary>
    /// Assessment Item Response Choice Pattern
    /// <para>
    /// The distribution of responses for each choice in the assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19385">Assessment Item Response Choice Pattern</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ResponseChoicePattern { get; set; }

    /// <summary>
    /// Assessment Item Characteristic Value
    /// <para>
    /// A psychometric measure provided for an assessment item.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19685">Assessment Item Characteristic Value</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Value { get; set; }

    #endregion
}