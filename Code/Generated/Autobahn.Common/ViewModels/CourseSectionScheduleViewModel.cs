//**********************************************************
//* DomainName: Common Models
//* FileName:   CourseSectionScheduleViewModel.cs
//* Name:       Class Beginning Time
//* Definition: An indication of the time of day the class begins.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// An indication of the time of day the class begins.
     /// </summary>
    public partial class CourseSectionScheduleViewModel : ViewModelBase, Interfaces.ICourseSectionSchedule
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionSchedule";

        // ClassBeginningTime -- (backing property for Class Beginning Time)
        private System.TimeSpan? _ClassBeginningTime;

        // ClassEndingTime -- (backing property for Class Ending Time)
        private System.TimeSpan? _ClassEndingTime;

        // ClassMeetingDays -- (backing property for Class Meeting Days)
        private System.String _ClassMeetingDays;

        // ClassPeriod -- (backing property for Class Period)
        private System.String _ClassPeriod;

        // member variable for the CourseSectionId property
        private Guid _CourseSectionId;

        // TimeDayIdentifier -- (backing property for Timetable Day Identifier)
        private System.String _TimeDayIdentifier;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Class Beginning Time
        /// <para>
        /// An indication of the time of day the class begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19510">Class Beginning Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.TimeSpan? ClassBeginningTime { get => _ClassBeginningTime; set => SetProperty(ref _ClassBeginningTime, value); }

        /// <summary>
        /// Class Ending Time
        /// <para>
        /// An indication of the time of day the class ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19511">Class Ending Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.TimeSpan? ClassEndingTime { get => _ClassEndingTime; set => SetProperty(ref _ClassEndingTime, value); }

        /// <summary>
        /// Class Meeting Days
        /// <para>
        /// The day(s) of the week (e.g., Monday, Wednesday) that the class meets or an indication that a class meets "out-of-school" or "self-paced".
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19512">Class Meeting Days</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ClassMeetingDays { get => _ClassMeetingDays; set => SetProperty(ref _ClassMeetingDays, value); }

        /// <summary>
        /// Class Period
        /// <para>
        /// An indication of the portion of a typical daily session in which students receive instruction in a specified subject (e.g., morning, sixth period, block period, or AB schedules).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19513">Class Period</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ClassPeriod { get => _ClassPeriod; set => SetProperty(ref _ClassPeriod, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourseSection"/> model
        /// </summary>
        public Guid CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

        /// <summary>
        /// Timetable Day Identifier
        /// <para>
        /// The unique identifier for the locally defined rotation cycle date code when the class meets (e.g., in a two day schedule, valid values could be "A" and "B", or "1" and "2").
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19514">Timetable Day Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String TimeDayIdentifier { get => _TimeDayIdentifier; set => SetProperty(ref _TimeDayIdentifier, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionSchedule model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassBeginningTime = model.ClassBeginningTime; // Class Beginning Time
            ClassEndingTime = model.ClassEndingTime; // Class Ending Time
            ClassMeetingDays = model.ClassMeetingDays; // Class Meeting Days
            ClassPeriod = model.ClassPeriod; // Class Period
            CourseSectionId = model.CourseSectionId; // 
            TimeDayIdentifier = model.TimeDayIdentifier; // Timetable Day Identifier
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
