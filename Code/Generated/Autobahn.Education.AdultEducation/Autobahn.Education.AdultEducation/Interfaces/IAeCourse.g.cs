//***************************************************************************
//* DomainName: Adult Education (AE)
//* FileName:   IAeCourse.g.cs
//***************************************************************************

/// <summary>
/// The IAeCourse file
/// </summary>
public partial interface IAeCourse
{
    #region "IAeCourse Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Career Cluster
    /// <para>
    /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
    /// </para>
    /// </summary>
    Guid? RefCareerClusterId { get; set; }

    /// <summary>
    /// Course Level Type
    /// <para>
    /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20278">Course Level Type</a>
    /// </para>
    /// </summary>
    Guid? RefCourseLevelTypeId { get; set; }

    #endregion
}
