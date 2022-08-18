//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELProgramLicensingViewModel.cs
//* Name:       Continuing License Date
//* Definition: The year, month and day on which a program or center received its continuing license.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The year, month and day on which a program or center received its continuing license.
     /// </summary>
    public partial class ELProgramLicensingViewModel : ViewModelBase, Interfaces.IELProgramLicensing
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELProgramLicensing";

        // ContinuingLicenseDate -- (backing property for Continuing License Date)
        private System.DateTime? _ContinuingLicenseDate;

        // InitialLicenseDate -- (backing property for Initial License Date)
        private System.DateTime? _InitialLicenseDate;

        // LicenseRevocationStatus -- (backing property for Early Learning Program License Revocation Status)
        private System.Boolean? _LicenseRevocationStatus;

        // LicenseSuspensionStatus -- (backing property for Early Learning Program License Suspension Status)
        private System.Boolean? _LicenseSuspensionStatus;

        // NumberOfFatalities -- (backing property for Number of Early Learning Fatalities)
        private System.Int32? _NumberOfFatalities;

        // NumberOfInjuries -- (backing property for Number of Early Learning Injuries)
        private System.Int32? _NumberOfInjuries;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefELProgramLicenseStatusId -- (backing property for Early Learning Program Licensing Status)
        private Guid? _RefELProgramLicenseStatusId;

        // RefLicenseExemptId -- (backing property for License Exempt)
        private Guid? _RefLicenseExemptId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Continuing License Date
        /// <para>
        /// The year, month and day on which a program or center received its continuing license.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19348">Continuing License Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? ContinuingLicenseDate { get => _ContinuingLicenseDate; set => SetProperty(ref _ContinuingLicenseDate, value); }

        /// <summary>
        /// Initial License Date
        /// <para>
        /// The year, month and day on which a program or center received its initial license.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19347">Initial License Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? InitialLicenseDate { get => _InitialLicenseDate; set => SetProperty(ref _InitialLicenseDate, value); }

        /// <summary>
        /// Early Learning Program License Revocation Status
        /// <para>
        /// An indication of whether a program's license was revoked due to violations as determined by the state.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19838">Early Learning Program License Revocation Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? LicenseRevocationStatus { get => _LicenseRevocationStatus; set => SetProperty(ref _LicenseRevocationStatus, value); }

        /// <summary>
        /// Early Learning Program License Suspension Status
        /// <para>
        /// An indication of whether a program's license was suspended due to violations as determined by the state.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19837">Early Learning Program License Suspension Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? LicenseSuspensionStatus { get => _LicenseSuspensionStatus; set => SetProperty(ref _LicenseSuspensionStatus, value); }

        /// <summary>
        /// Number of Early Learning Fatalities
        /// <para>
        /// Number of child fatalities at the program in the past year, as defined by the State
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19835">Number of Early Learning Fatalities</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? NumberOfFatalities { get => _NumberOfFatalities; set => SetProperty(ref _NumberOfFatalities, value); }

        /// <summary>
        /// Number of Early Learning Injuries
        /// <para>
        /// Number of child injuries at the program in the past year, as defined by the State.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19836">Number of Early Learning Injuries</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Int32? NumberOfInjuries { get => _NumberOfInjuries; set => SetProperty(ref _NumberOfInjuries, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Early Learning Program Licensing Status
        /// <para>
        /// The current licensing status for an early learning program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19828">Early Learning Program Licensing Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELProgramLicenseStatusId { get => _RefELProgramLicenseStatusId; set => SetProperty(ref _RefELProgramLicenseStatusId, value); }

        /// <summary>
        /// License Exempt
        /// <para>
        /// The program or center is legally exempt from licensing.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19349">License Exempt</a>
        /// </para>
        /// </summary>
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
            ContinuingLicenseDate = model.ContinuingLicenseDate; // Continuing License Date
            InitialLicenseDate = model.InitialLicenseDate; // Initial License Date
            LicenseRevocationStatus = model.LicenseRevocationStatus; // Early Learning Program License Revocation Status
            LicenseSuspensionStatus = model.LicenseSuspensionStatus; // Early Learning Program License Suspension Status
            NumberOfFatalities = model.NumberOfFatalities; // Number of Early Learning Fatalities
            NumberOfInjuries = model.NumberOfInjuries; // Number of Early Learning Injuries
            OrganizationId = model.OrganizationId; // 
            RefELProgramLicenseStatusId = model.RefELProgramLicenseStatusId; // Early Learning Program Licensing Status
            RefLicenseExemptId = model.RefLicenseExemptId; // License Exempt
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
