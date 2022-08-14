//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentSubtestELDevelopmentalDomainViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the AssessmentSubtestId property
        private Guid _AssessmentSubtestId;

        // member variable for the RefAssessmentELDevelopmentalDomainId property
        private Guid _RefAssessmentELDevelopmentalDomainId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSubtestELDevelopmentalDomainViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentSubtest"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get => _AssessmentSubtestId; set => SetProperty(ref _AssessmentSubtestId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentELDevelopmentalDomain"/> model
        /// </summary>
        public Guid RefAssessmentELDevelopmentalDomainId { get => _RefAssessmentELDevelopmentalDomainId; set => SetProperty(ref _RefAssessmentELDevelopmentalDomainId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentSubtestELDevelopmentalDomain model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentSubtestId = model.AssessmentSubtestId;
            RefAssessmentELDevelopmentalDomainId = model.RefAssessmentELDevelopmentalDomainId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
