//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsInstitutionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsInstitutionViewModel
     /// </summary>
    public partial class PsInstitutionViewModel : ViewModelBase, Interfaces.IPsInstitution
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsInstitution";

        // member variable for the InstitutionallyControlledHousingStatus property
        private  _InstitutionallyControlledHousingStatus;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAdministrativeFundingControlId property
        private Guid? _RefAdministrativeFundingControlId;

        // member variable for the RefAdmissionConsiderationLevelId property
        private  _RefAdmissionConsiderationLevelId;

        // member variable for the RefAdmissionConsiderationTypeId property
        private  _RefAdmissionConsiderationTypeId;

        // member variable for the RefCarnegieBasicClassificationId property
        private  _RefCarnegieBasicClassificationId;

        // member variable for the RefControlOfInstitutionId property
        private  _RefControlOfInstitutionId;

        // member variable for the RefIncreasedLearningTimeTypeId property
        private  _RefIncreasedLearningTimeTypeId;

        // member variable for the RefLevelOfInstitutionId property
        private  _RefLevelOfInstitutionId;

        // member variable for the RefPredominantCalendarSystemId property
        private  _RefPredominantCalendarSystemId;

        // member variable for the RefTenureSystemId property
        private  _RefTenureSystemId;

        // member variable for the VirtualIndicator property
        private  _VirtualIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  InstitutionallyControlledHousingStatus { get => _InstitutionallyControlledHousingStatus; set => SetProperty(ref _InstitutionallyControlledHousingStatus, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get => _RefAdministrativeFundingControlId; set => SetProperty(ref _RefAdministrativeFundingControlId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmissionConsiderationLevel"/> model
        /// </summary>
        public  RefAdmissionConsiderationLevelId { get => _RefAdmissionConsiderationLevelId; set => SetProperty(ref _RefAdmissionConsiderationLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmissionConsiderationType"/> model
        /// </summary>
        public  RefAdmissionConsiderationTypeId { get => _RefAdmissionConsiderationTypeId; set => SetProperty(ref _RefAdmissionConsiderationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCarnegieBasicClassification"/> model
        /// </summary>
        public  RefCarnegieBasicClassificationId { get => _RefCarnegieBasicClassificationId; set => SetProperty(ref _RefCarnegieBasicClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefControlOfInstitution"/> model
        /// </summary>
        public  RefControlOfInstitutionId { get => _RefControlOfInstitutionId; set => SetProperty(ref _RefControlOfInstitutionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
        /// </summary>
        public  RefIncreasedLearningTimeTypeId { get => _RefIncreasedLearningTimeTypeId; set => SetProperty(ref _RefIncreasedLearningTimeTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLevelOfInstitution"/> model
        /// </summary>
        public  RefLevelOfInstitutionId { get => _RefLevelOfInstitutionId; set => SetProperty(ref _RefLevelOfInstitutionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPredominantCalendarSystem"/> model
        /// </summary>
        public  RefPredominantCalendarSystemId { get => _RefPredominantCalendarSystemId; set => SetProperty(ref _RefPredominantCalendarSystemId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTenureSystem"/> model
        /// </summary>
        public  RefTenureSystemId { get => _RefTenureSystemId; set => SetProperty(ref _RefTenureSystemId, value); }

        /// <summary>
        /// </summary>
        public  VirtualIndicator { get => _VirtualIndicator; set => SetProperty(ref _VirtualIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsInstitution model)
        {
            IsBusy = true;
            Id = model.Id;
            InstitutionallyControlledHousingStatus = model.InstitutionallyControlledHousingStatus; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAdministrativeFundingControlId = model.RefAdministrativeFundingControlId; // 
            RefAdmissionConsiderationLevelId = model.RefAdmissionConsiderationLevelId; // 
            RefAdmissionConsiderationTypeId = model.RefAdmissionConsiderationTypeId; // 
            RefCarnegieBasicClassificationId = model.RefCarnegieBasicClassificationId; // 
            RefControlOfInstitutionId = model.RefControlOfInstitutionId; // 
            RefIncreasedLearningTimeTypeId = model.RefIncreasedLearningTimeTypeId; // 
            RefLevelOfInstitutionId = model.RefLevelOfInstitutionId; // 
            RefPredominantCalendarSystemId = model.RefPredominantCalendarSystemId; // 
            RefTenureSystemId = model.RefTenureSystemId; // 
            VirtualIndicator = model.VirtualIndicator; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
