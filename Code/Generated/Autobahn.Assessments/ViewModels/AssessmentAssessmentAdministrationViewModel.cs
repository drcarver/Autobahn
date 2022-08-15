//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAssessmentAdministrationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentAssessmentAdministrationViewModel
     /// </summary>
    public partial class AssessmentAssessmentAdministrationViewModel : ViewModelBase, Interfaces.IAssessmentAssessmentAdministration
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentAssessmentAdministration";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentAssessmentAdministrationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAssessmentAdministration model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
