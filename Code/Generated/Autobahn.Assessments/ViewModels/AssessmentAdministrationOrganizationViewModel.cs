//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAdministrationOrganizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentAdministrationOrganizationViewModel
     /// </summary>
    public partial class AssessmentAdministrationOrganizationViewModel : ViewModelBase, Interfaces.IAssessmentAdministrationOrganization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentAdministrationOrganization";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentAdministrationOrganizationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAdministrationOrganization model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
