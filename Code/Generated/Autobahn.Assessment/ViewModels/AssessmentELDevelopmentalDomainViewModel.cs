//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentELDevelopmentalDomainViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentELDevelopmentalDomainViewModel
     /// </summary>
    public partial class AssessmentELDevelopmentalDomainViewModel : ViewModelBase, Interfaces.IAssessmentELDevelopmentalDomainViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentELDevelopmentalDomain";

        // member variable for the AssessmentId property
        private Guid _AssessmentId;

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
        /// The title of the AssessmentELDevelopmentalDomainViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentId"/> model
        /// </summary>
        public Guid AssessmentId { get => _AssessmentId; set => SetProperty(ref _AssessmentId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefAssessmentELDevelopmentalDomainId"/> model
        /// </summary>
        public Guid RefAssessmentELDevelopmentalDomainId { get => _RefAssessmentELDevelopmentalDomainId; set => SetProperty(ref _RefAssessmentELDevelopmentalDomainId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentELDevelopmentalDomain model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentId = model.AssessmentId;
            RefAssessmentELDevelopmentalDomainId = model.RefAssessmentELDevelopmentalDomainId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
