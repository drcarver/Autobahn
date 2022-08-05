//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentSubtestELDevelopmentalDomainViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
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

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentSubtestELDevelopmentalDomainViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentSubtestId"/> model
        /// </summary>
        public Guid AssessmentSubtestId { get => _AssessmentSubtestId; set => SetProperty(ref _AssessmentSubtestId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentELDevelopmentalDomainId"/> model
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
