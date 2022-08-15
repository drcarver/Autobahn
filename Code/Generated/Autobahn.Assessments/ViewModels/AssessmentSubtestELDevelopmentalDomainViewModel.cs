//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestELDevelopmentalDomainViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentSubtestELDevelopmentalDomainViewModel
     /// </summary>
    public partial class AssessmentSubtestELDevelopmentalDomainViewModel : ViewModelBase, Interfaces.IAssessmentSubtestELDevelopmentalDomain
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentSubtestELDevelopmentalDomain";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSubtestELDevelopmentalDomainViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtestELDevelopmentalDomain model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
