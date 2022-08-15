//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentELDevelopmentalDomainViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentELDevelopmentalDomainViewModel
     /// </summary>
    public partial class AssessmentELDevelopmentalDomainViewModel : ViewModelBase, Interfaces.IAssessmentELDevelopmentalDomain
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentELDevelopmentalDomain";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentELDevelopmentalDomainViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentELDevelopmentalDomain model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
