//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentAccommodationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Assessment.Interfaces;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentAccommodationViewModel
     /// </summary>
    public partial class AssessmentAccommodationViewModel : BindableBase, IAssessmentAccommodation
    {
#region "Backing Fields"
        // member variable for the OtherDescription property
        private System.String _OtherDescription;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        public System.String OtherDescription  { get => _OtherDescription; set => SetProperty(ref _OtherDescription, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAccommodationTypeId"/> model
        /// </summary>
        public Guid? RefAccommodationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentAccommodationCategoryId"/> model
        /// </summary>
        public Guid? RefAssessmentAccommodationCategoryId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IAssessmentAccommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            OtherDescription = model.OtherDescription;
            RefAccommodationTypeId = model.RefAccommodationTypeId;
            RefAssessmentAccommodationCategoryId = model.RefAssessmentAccommodationCategoryId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
