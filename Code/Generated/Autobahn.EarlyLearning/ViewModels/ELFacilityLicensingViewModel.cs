//**********************************************************
//* DomainName: Early Learning (EL)
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

        // member variable for the ContinuingLicenseDate property
        private System.DateTime? _ContinuingLicenseDate;

        // member variable for the InitialLicensingDate property
        private System.DateTime? _InitialLicensingDate;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefELFacilityLicensingStatusId property
        private Guid? _RefELFacilityLicensingStatusId;

        // member variable for the RefLicenseExemptId property
        private Guid? _RefLicenseExemptId;

        // member variable for the StateLicensedFacilityCapacity property
        private System.Int32? _StateLicensedFacilityCapacity;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELFacilityLicensingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.DateTime? ContinuingLicenseDate { get => _ContinuingLicenseDate; set => SetProperty(ref _ContinuingLicenseDate, value); }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.DateTime? InitialLicensingDate { get => _InitialLicensingDate; set => SetProperty(ref _InitialLicensingDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELFacilityLicensingStatus"/> model
        /// </summary>
        public Guid? RefELFacilityLicensingStatusId { get => _RefELFacilityLicensingStatusId; set => SetProperty(ref _RefELFacilityLicensingStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLicenseExempt"/> model
        /// </summary>
        public Guid? RefLicenseExemptId { get => _RefLicenseExemptId; set => SetProperty(ref _RefLicenseExemptId, value); }

        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        public System.Int32? StateLicensedFacilityCapacity { get => _StateLicensedFacilityCapacity; set => SetProperty(ref _StateLicensedFacilityCapacity, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELFacilityLicensing model)
        {
            IsBusy = true;
            Id = model.Id;
            ContinuingLicenseDate = model.ContinuingLicenseDate;
            InitialLicensingDate = model.InitialLicensingDate;
            OrganizationId = model.OrganizationId;
            RefELFacilityLicensingStatusId = model.RefELFacilityLicensingStatusId;
            RefLicenseExemptId = model.RefLicenseExemptId;
            StateLicensedFacilityCapacity = model.StateLicensedFacilityCapacity;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
