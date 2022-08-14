//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsInstitutionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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
        private System.Boolean? _InstitutionallyControlledHousingStatus;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefAdministrativeFundingControlId property
        private Guid? _RefAdministrativeFundingControlId;

        // member variable for the RefAdmissionConsiderationLevelId property
        private Guid? _RefAdmissionConsiderationLevelId;

        // member variable for the RefAdmissionConsiderationTypeId property
        private Guid? _RefAdmissionConsiderationTypeId;

        // member variable for the RefCarnegieBasicClassificationId property
        private Guid? _RefCarnegieBasicClassificationId;

        // member variable for the RefControlOfInstitutionId property
        private Guid? _RefControlOfInstitutionId;

        // member variable for the RefIncreasedLearningTimeTypeId property
        private Guid? _RefIncreasedLearningTimeTypeId;

        // member variable for the RefLevelOfInstitutionId property
        private Guid? _RefLevelOfInstitutionId;

        // member variable for the RefPredominantCalendarSystemId property
        private Guid? _RefPredominantCalendarSystemId;

        // member variable for the RefTenureSystemId property
        private Guid? _RefTenureSystemId;

        // member variable for the VirtualIndicator property
        private System.Boolean? _VirtualIndicator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsInstitutionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.Boolean? InstitutionallyControlledHousingStatus { get => _InstitutionallyControlledHousingStatus; set => SetProperty(ref _InstitutionallyControlledHousingStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get => _RefAdministrativeFundingControlId; set => SetProperty(ref _RefAdministrativeFundingControlId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmissionConsiderationLevel"/> model
        /// </summary>
        public Guid? RefAdmissionConsiderationLevelId { get => _RefAdmissionConsiderationLevelId; set => SetProperty(ref _RefAdmissionConsiderationLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmissionConsiderationType"/> model
        /// </summary>
        public Guid? RefAdmissionConsiderationTypeId { get => _RefAdmissionConsiderationTypeId; set => SetProperty(ref _RefAdmissionConsiderationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCarnegieBasicClassification"/> model
        /// </summary>
        public Guid? RefCarnegieBasicClassificationId { get => _RefCarnegieBasicClassificationId; set => SetProperty(ref _RefCarnegieBasicClassificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefControlOfInstitution"/> model
        /// </summary>
        public Guid? RefControlOfInstitutionId { get => _RefControlOfInstitutionId; set => SetProperty(ref _RefControlOfInstitutionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
        /// </summary>
        public Guid? RefIncreasedLearningTimeTypeId { get => _RefIncreasedLearningTimeTypeId; set => SetProperty(ref _RefIncreasedLearningTimeTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLevelOfInstitution"/> model
        /// </summary>
        public Guid? RefLevelOfInstitutionId { get => _RefLevelOfInstitutionId; set => SetProperty(ref _RefLevelOfInstitutionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPredominantCalendarSystem"/> model
        /// </summary>
        public Guid? RefPredominantCalendarSystemId { get => _RefPredominantCalendarSystemId; set => SetProperty(ref _RefPredominantCalendarSystemId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTenureSystem"/> model
        /// </summary>
        public Guid? RefTenureSystemId { get => _RefTenureSystemId; set => SetProperty(ref _RefTenureSystemId, value); }

        /// <summary>
        /// The type of education institution as classified by its funding source.
        /// </summary>
        public System.Boolean? VirtualIndicator { get => _VirtualIndicator; set => SetProperty(ref _VirtualIndicator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsInstitution model)
        {
            IsBusy = true;
            Id = model.Id;
            InstitutionallyControlledHousingStatus = model.InstitutionallyControlledHousingStatus;
            OrganizationId = model.OrganizationId;
            RefAdministrativeFundingControlId = model.RefAdministrativeFundingControlId;
            RefAdmissionConsiderationLevelId = model.RefAdmissionConsiderationLevelId;
            RefAdmissionConsiderationTypeId = model.RefAdmissionConsiderationTypeId;
            RefCarnegieBasicClassificationId = model.RefCarnegieBasicClassificationId;
            RefControlOfInstitutionId = model.RefControlOfInstitutionId;
            RefIncreasedLearningTimeTypeId = model.RefIncreasedLearningTimeTypeId;
            RefLevelOfInstitutionId = model.RefLevelOfInstitutionId;
            RefPredominantCalendarSystemId = model.RefPredominantCalendarSystemId;
            RefTenureSystemId = model.RefTenureSystemId;
            VirtualIndicator = model.VirtualIndicator;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
