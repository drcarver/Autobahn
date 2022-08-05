//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAccommodationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentAccommodationViewModel
     /// </summary>
    public partial class AssessmentAccommodationViewModel : ViewModelBase, Interfaces.IAssessmentAccommodation
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentAccommodation";

        // member variable for the OtherDescription property
        private System.String _OtherDescription;

        // member variable for the RefAccommodationTypeId property
        private Guid? _RefAccommodationTypeId;

        // member variable for the RefAssessmentAccommodationCategoryId property
        private Guid? _RefAssessmentAccommodationCategoryId;

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
        /// The title of the AssessmentAccommodationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String OtherDescription  { get => _OtherDescription; set => SetProperty(ref _OtherDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationTypeId"/> model
        /// </summary>
        public Guid? RefAccommodationTypeId { get => _RefAccommodationTypeId; set => SetProperty(ref _RefAccommodationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentAccommodationCategoryId"/> model
        /// </summary>
        public Guid? RefAssessmentAccommodationCategoryId { get => _RefAssessmentAccommodationCategoryId; set => SetProperty(ref _RefAssessmentAccommodationCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAccommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            OtherDescription = model.OtherDescription;
            RefAccommodationTypeId = model.RefAccommodationTypeId;
            RefAssessmentAccommodationCategoryId = model.RefAssessmentAccommodationCategoryId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
