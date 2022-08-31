//***************************************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarEventEntity.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationCalendarEvent file
/// </summary>
[Table("OrganizationCalendarEvent", Schema = "Common")]
public partial class OrganizationCalendarEventEntity : EntityBase, IOrganizationCalendarEvent
{
    #region "IOrganizationCalendarEvent Properties"
    /// <summary>
    /// End Time
    /// <para>
    /// The ending hour, minute and second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20901">End Time</a>
    /// </para>
    /// </summary>
    public TimeSpan? EndTime { get; set; }

    /// <summary>
    /// Calendar Event Date
    /// <para>
    /// The date of the scheduled or unscheduled calendar event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20241">Calendar Event Date</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    public System.DateTime EventDate { get; set; }

    /// <summary>
    /// Calendar Event Day Name
    /// <para>
    /// A name used for the day of the calendar event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20242">Calendar Event Day Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String Name { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationCalendar"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationCalendar")]
    public Guid OrganizationCalendarId { get; set; }

    /// <summary>
    /// Calendar Event Type
    /// <para>
    /// A type of scheduled or unscheduled calendar event.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19596">Calendar Event Type</a>
    /// </para>
    /// </summary>
    public Int32? RefCalendarEventType { get; set; }

    /// <summary>
    /// Start Time
    /// <para>
    /// The starting hour, minute and second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20900">Start Time</a>
    /// </para>
    /// </summary>
    public TimeSpan? StartTime { get; set; }

    #endregion
}