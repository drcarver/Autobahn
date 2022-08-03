//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsInstitutionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsInstitutionViewModel
     /// </summary>
    public partial class PsInstitutionViewModel : BindableBase, IPsInstitution
    {
#region "Backing Fields"
        // member variable for the VirtualIndicator property
        private System.Boolean? _VirtualIndicator;

        // member variable for the InstitutionallyControlledHousingStatus property
        private System.Boolean? _InstitutionallyControlledHousingStatus;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        public System.Boolean? VirtualIndicator { get => _VirtualIndicator; set => SetProperty(ref _VirtualIndicator, value); }

        public System.Boolean? InstitutionallyControlledHousingStatus { get => _InstitutionallyControlledHousingStatus; set => SetProperty(ref _InstitutionallyControlledHousingStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCarnegieBasicClassificationId"/> model
        /// </summary>
        public Guid? RefCarnegieBasicClassificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefControlOfInstitutionId"/> model
        /// </summary>
        public Guid? RefControlOfInstitutionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLevelOfInstitutionId"/> model
        /// </summary>
        public Guid? RefLevelOfInstitutionId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPredominantCalendarSystemId"/> model
        /// </summary>
        public Guid? RefPredominantCalendarSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTenureSystemId"/> model
        /// </summary>
        public Guid? RefTenureSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmissionConsiderationLevelId"/> model
        /// </summary>
        public Guid? RefAdmissionConsiderationLevelId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmissionConsiderationTypeId"/> model
        /// </summary>
        public Guid? RefAdmissionConsiderationTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControlId"/> model
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeTypeId"/> model
        /// </summary>
        public Guid? RefIncreasedLearningTimeTypeId { get; set; }

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
        public void Load(IPsInstitution model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            VirtualIndicator = model.VirtualIndicator;
            InstitutionallyControlledHousingStatus = model.InstitutionallyControlledHousingStatus;
            RefCarnegieBasicClassificationId = model.RefCarnegieBasicClassificationId;
            RefControlOfInstitutionId = model.RefControlOfInstitutionId;
            RefLevelOfInstitutionId = model.RefLevelOfInstitutionId;
            RefPredominantCalendarSystemId = model.RefPredominantCalendarSystemId;
            RefTenureSystemId = model.RefTenureSystemId;
            RefAdmissionConsiderationLevelId = model.RefAdmissionConsiderationLevelId;
            RefAdmissionConsiderationTypeId = model.RefAdmissionConsiderationTypeId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RefAdministrativeFundingControlId = model.RefAdministrativeFundingControlId;
            RefIncreasedLearningTimeTypeId = model.RefIncreasedLearningTimeTypeId;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
