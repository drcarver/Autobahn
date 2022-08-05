//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELFacilityLicensingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELFacilityLicensingViewModel
     /// </summary>
    public partial class ELFacilityLicensingViewModel : ViewModelBase, Interfaces.IELFacilityLicensing
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELFacilityLicensing";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefELFacilityLicensingStatusId property
        private Guid? _RefELFacilityLicensingStatusId;

        // member variable for the StateLicensedFacilityCapacity property
        private System.Int32? _StateLicensedFacilityCapacity;

        // member variable for the InitialLicensingDate property
        private System.DateTime? _InitialLicensingDate;

        // member variable for the ContinuingLicenseDate property
        private System.DateTime? _ContinuingLicenseDate;

        // member variable for the RefLicenseExemptId property
        private Guid? _RefLicenseExemptId;

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
        /// The title of the ELFacilityLicensingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFacilityLicensingStatusId"/> model
        /// </summary>
        public Guid? RefELFacilityLicensingStatusId { get => _RefELFacilityLicensingStatusId; set => SetProperty(ref _RefELFacilityLicensingStatusId, value); }

        public System.Int32? StateLicensedFacilityCapacity { get => _StateLicensedFacilityCapacity; set => SetProperty(ref _StateLicensedFacilityCapacity, value); }

        public System.DateTime? InitialLicensingDate { get => _InitialLicensingDate; set => SetProperty(ref _InitialLicensingDate, value); }

        public System.DateTime? ContinuingLicenseDate { get => _ContinuingLicenseDate; set => SetProperty(ref _ContinuingLicenseDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLicenseExemptId"/> model
        /// </summary>
        public Guid? RefLicenseExemptId { get => _RefLicenseExemptId; set => SetProperty(ref _RefLicenseExemptId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELFacilityLicensing model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefELFacilityLicensingStatusId = model.RefELFacilityLicensingStatusId;
            StateLicensedFacilityCapacity = model.StateLicensedFacilityCapacity;
            InitialLicensingDate = model.InitialLicensingDate;
            ContinuingLicenseDate = model.ContinuingLicenseDate;
            RefLicenseExemptId = model.RefLicenseExemptId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
