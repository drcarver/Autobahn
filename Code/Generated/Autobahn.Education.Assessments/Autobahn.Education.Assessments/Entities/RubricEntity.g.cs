//***************************************************************************
//* DomainName: Assessments
//* FileName:   RubricEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRubric file
/// </summary>
[Table("Rubric", Schema = "Assessments")]
public partial class RubricEntity : EntityBase, IRubric
{
    #region "IRubric Properties"
    /// <summary>
    /// Rubric Identifier
    /// <para>
    /// An identifier assigned to a rubric.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19412">Rubric Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Identifier { get; set; }

    /// <summary>
    /// Rubric Title
    /// <para>
    /// The title of the rubric.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19411">Rubric Title</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Title { get; set; }

    /// <summary>
    /// Rubric URL Reference
    /// <para>
    /// The URL location where the rubric may be found.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19413">Rubric URL Reference</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(512,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String UrlReference { get; set; }

    #endregion
}