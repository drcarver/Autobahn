//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentFormAssessmentFormSectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentFormAssessmentFormSectionViewModel
     /// </summary>
    public partial class AssessmentFormAssessmentFormSectionViewModel : ViewModelBase, Interfaces.IAssessmentFormAssessmentFormSection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentFormAssessmentFormSection";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentFormAssessmentFormSectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormAssessmentFormSection model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
