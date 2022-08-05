//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELProgramLicensingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELProgramLicensingViewModel
     /// </summary>
    public partial class ELProgramLicensingViewModel : ViewModelBase, Interfaces.IELProgramLicensing
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELProgramLicensing";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefELProgramLicenseStatusId property
        private Guid? _RefELProgramLicenseStatusId;

        // member variable for the InitialLicenseDate property
        private System.DateTime? _InitialLicenseDate;

        // member variable for the ContinuingLicenseDate property
        private System.DateTime? _ContinuingLicenseDate;

        // member variable for the LicenseSuspensionStatus property
        private System.Boolean? _LicenseSuspensionStatus;

        // member variable for the LicenseRevocationStatus property
        private System.Boolean? _LicenseRevocationStatus;

        // member variable for the NumberOfFatalities property
        private System.Int32? _NumberOfFatalities;

        // member variable for the NumberOfInjuries property
        private System.Int32? _NumberOfInjuries;

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
        /// The title of the ELProgramLicensingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramLicenseStatusId"/> model
        /// </summary>
        public Guid? RefELProgramLicenseStatusId { get => _RefELProgramLicenseStatusId; set => SetProperty(ref _RefELProgramLicenseStatusId, value); }

        public System.DateTime? InitialLicenseDate { get => _InitialLicenseDate; set => SetProperty(ref _InitialLicenseDate, value); }

        public System.DateTime? ContinuingLicenseDate { get => _ContinuingLicenseDate; set => SetProperty(ref _ContinuingLicenseDate, value); }

        public System.Boolean? LicenseSuspensionStatus { get => _LicenseSuspensionStatus; set => SetProperty(ref _LicenseSuspensionStatus, value); }

        public System.Boolean? LicenseRevocationStatus { get => _LicenseRevocationStatus; set => SetProperty(ref _LicenseRevocationStatus, value); }

        public System.Int32? NumberOfFatalities { get => _NumberOfFatalities; set => SetProperty(ref _NumberOfFatalities, value); }

        public System.Int32? NumberOfInjuries { get => _NumberOfInjuries; set => SetProperty(ref _NumberOfInjuries, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLicenseExemptId"/> model
        /// </summary>
        public Guid? RefLicenseExemptId { get => _RefLicenseExemptId; set => SetProperty(ref _RefLicenseExemptId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELProgramLicensing model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefELProgramLicenseStatusId = model.RefELProgramLicenseStatusId;
            InitialLicenseDate = model.InitialLicenseDate;
            ContinuingLicenseDate = model.ContinuingLicenseDate;
            LicenseSuspensionStatus = model.LicenseSuspensionStatus;
            LicenseRevocationStatus = model.LicenseRevocationStatus;
            NumberOfFatalities = model.NumberOfFatalities;
            NumberOfInjuries = model.NumberOfInjuries;
            RefLicenseExemptId = model.RefLicenseExemptId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
