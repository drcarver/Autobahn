//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProfessionalDevelopmentRequirementViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProfessionalDevelopmentRequirementViewModel
     /// </summary>
    public partial class ProfessionalDevelopmentRequirementViewModel : ViewModelBase, Interfaces.IProfessionalDevelopmentRequirement
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProfessionalDevelopmentRequirement";

        // member variable for the RequiredTrainingClockHours property
        private System.Decimal? _RequiredTrainingClockHours;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProfessionalDevelopmentRequirementViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Number of clock hours of training required for providers to meet requirements of the state.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19803">Required Training Clock Hours</a>
        /// </para>
        /// </summary>
        [DisplayName("Required Training Clock Hours")]
        public System.Decimal? RequiredTrainingClockHours { get => _RequiredTrainingClockHours; set => SetProperty(ref _RequiredTrainingClockHours, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProfessionalDevelopmentRequirement model)
        {
            IsBusy = true;
            Id = model.Id;
            RequiredTrainingClockHours = model.RequiredTrainingClockHours; // Required Training Clock Hours
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
