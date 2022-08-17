//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   ICourseSectionSchedule.cs
//* Name:       Class Beginning Time
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface ICourseSectionSchedule : IAutobahnBase
    {
        /// <summary>
        /// Class Beginning Time
        /// <para>
        /// An indication of the time of day the class begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19510">Class Beginning Time</a>
        /// </para>
        /// </summary>
        System.TimeSpan? ClassBeginningTime { get; set; }

        /// <summary>
        /// Class Ending Time
        /// <para>
        /// An indication of the time of day the class ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19511">Class Ending Time</a>
        /// </para>
        /// </summary>
        System.TimeSpan? ClassEndingTime { get; set; }

        /// <summary>
        /// Class Meeting Days
        /// <para>
        /// The day(s) of the week (e.g., Monday, Wednesday) that the class meets or an indication that a class meets "out-of-school" or "self-paced".
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19512">Class Meeting Days</a>
        /// </para>
        /// </summary>
        System.String ClassMeetingDays { get; set; }

        /// <summary>
        /// Class Period
        /// <para>
        /// An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19513">Class Period</a>
        /// </para>
        /// </summary>
        System.String ClassPeriod { get; set; }

        /// <summary>
        /// Available Carnegie Unit Credit
        /// <para>
        /// Measured in Carnegie units, the amount of credit available to a student who successfully meets the objectives of the course. A course meeting every day for one period of the school day over the span of a school year offers one Carnegie unit. A Carnegie unit is thus a measure of "seat time" rather than a measure of attainment of the course objectives.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19030">Available Carnegie Unit Credit</a>
        /// </para>
        /// </summary>
        Guid CourseSectionId { get; set; }

        /// <summary>
        /// Timetable Day Identifier
        /// <para>
        /// The unique identifier for the locally defined rotation cycle date code when the class meets (e.g., in a two day schedule, valid values could be "A" and "B", or "1" and "2").
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19514">Timetable Day Identifier</a>
        /// </para>
        /// </summary>
        System.String TimeDayIdentifier { get; set; }

    }
}
