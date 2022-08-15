//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCareerEducationPlanViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonCareerEducationPlanViewModel
     /// </summary>
    public partial class PersonCareerEducationPlanViewModel : ViewModelBase, Interfaces.IPersonCareerEducationPlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonCareerEducationPlan";

        // member variable for the LastUpdated property
        private System.DateTime? _LastUpdated;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonCareerEducationPlanViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The date on which an individual's professional development career plan was last updated.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20255">Career Education Plan Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Career Education Plan Date")]
        public System.DateTime? LastUpdated { get => _LastUpdated; set => SetProperty(ref _LastUpdated, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonCareerEducationPlan model)
        {
            IsBusy = true;
            Id = model.Id;
            LastUpdated = model.LastUpdated; // Career Education Plan Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
