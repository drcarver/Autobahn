//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELProgramLicensingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the ContinuingLicenseDate property
        private System.DateTime? _ContinuingLicenseDate;

        // member variable for the InitialLicenseDate property
        private System.DateTime? _InitialLicenseDate;

        // member variable for the LicenseRevocationStatus property
        private System.Boolean? _LicenseRevocationStatus;

        // member variable for the LicenseSuspensionStatus property
        private System.Boolean? _LicenseSuspensionStatus;

        // member variable for the NumberOfFatalities property
        private System.Int32? _NumberOfFatalities;

        // member variable for the NumberOfInjuries property
        private System.Int32? _NumberOfInjuries;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefELProgramLicenseStatusId property
        private Guid? _RefELProgramLicenseStatusId;

        // member variable for the RefLicenseExemptId property
        private Guid? _RefLicenseExemptId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELProgramLicensingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.DateTime? ContinuingLicenseDate { get => _ContinuingLicenseDate; set => SetProperty(ref _ContinuingLicenseDate, value); }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.DateTime? InitialLicenseDate { get => _InitialLicenseDate; set => SetProperty(ref _InitialLicenseDate, value); }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.Boolean? LicenseRevocationStatus { get => _LicenseRevocationStatus; set => SetProperty(ref _LicenseRevocationStatus, value); }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.Boolean? LicenseSuspensionStatus { get => _LicenseSuspensionStatus; set => SetProperty(ref _LicenseSuspensionStatus, value); }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.Int32? NumberOfFatalities { get => _NumberOfFatalities; set => SetProperty(ref _NumberOfFatalities, value); }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.Int32? NumberOfInjuries { get => _NumberOfInjuries; set => SetProperty(ref _NumberOfInjuries, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramLicenseStatus"/> model
        /// </summary>
        public Guid? RefELProgramLicenseStatusId { get => _RefELProgramLicenseStatusId; set => SetProperty(ref _RefELProgramLicenseStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
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
            ContinuingLicenseDate = model.ContinuingLicenseDate;
            InitialLicenseDate = model.InitialLicenseDate;
            LicenseRevocationStatus = model.LicenseRevocationStatus;
            LicenseSuspensionStatus = model.LicenseSuspensionStatus;
            NumberOfFatalities = model.NumberOfFatalities;
            NumberOfInjuries = model.NumberOfInjuries;
            OrganizationId = model.OrganizationId;
            RefELProgramLicenseStatusId = model.RefELProgramLicenseStatusId;
            RefLicenseExemptId = model.RefLicenseExemptId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
