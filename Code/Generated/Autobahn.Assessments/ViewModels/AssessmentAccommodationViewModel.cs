//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAccommodationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
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
        private  _OtherDescription;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAccommodationTypeId property
        private  _RefAccommodationTypeId;

        // member variable for the RefAssessmentAccommodationCategoryId property
        private Guid? _RefAssessmentAccommodationCategoryId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  OtherDescription { get => _OtherDescription; set => SetProperty(ref _OtherDescription, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationType"/> model
        /// </summary>
        public  RefAccommodationTypeId { get => _RefAccommodationTypeId; set => SetProperty(ref _RefAccommodationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentAccommodationCategory"/> model
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
            OtherDescription = model.OtherDescription; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAccommodationTypeId = model.RefAccommodationTypeId; // 
            RefAssessmentAccommodationCategoryId = model.RefAssessmentAccommodationCategoryId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
