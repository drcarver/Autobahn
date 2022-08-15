//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionScheduleViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The CourseSectionScheduleViewModel
     /// </summary>
    public partial class CourseSectionScheduleViewModel : ViewModelBase, Interfaces.ICourseSectionSchedule
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionSchedule";

        // member variable for the ClassBeginningTime property
        private System.TimeSpan? _ClassBeginningTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CourseSectionScheduleViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication of the time of day the class begins.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19510">Class Beginning Time</a>
        /// </para>
        /// </summary>
        [DisplayName("Class Beginning Time")]
        public System.TimeSpan? ClassBeginningTime { get => _ClassBeginningTime; set => SetProperty(ref _ClassBeginningTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionSchedule model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassBeginningTime = model.ClassBeginningTime; // Class Beginning Time
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
