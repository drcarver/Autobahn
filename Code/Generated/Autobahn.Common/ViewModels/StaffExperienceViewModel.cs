//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffExperienceViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffExperienceViewModel
     /// </summary>
    public partial class StaffExperienceViewModel : ViewModelBase, Interfaces.IStaffExperience
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffExperience";

        // member variable for the YearsOfPriorTeachingExperience property
        private System.Decimal? _YearsOfPriorTeachingExperience;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffExperienceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The total number of years prior to this job that a person has previously held a teaching position in one or more education institutions.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19302">Years of Prior Teaching Experience</a>
        /// </para>
        /// </summary>
        [DisplayName("Years of Prior Teaching Experience")]
        public System.Decimal? YearsOfPriorTeachingExperience { get => _YearsOfPriorTeachingExperience; set => SetProperty(ref _YearsOfPriorTeachingExperience, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffExperience model)
        {
            IsBusy = true;
            Id = model.Id;
            YearsOfPriorTeachingExperience = model.YearsOfPriorTeachingExperience; // Years of Prior Teaching Experience
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
