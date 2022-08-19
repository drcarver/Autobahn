//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELFacilityLicensingViewModel.cs
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
    public partial class ELFacilityLicensingViewModel : ViewModelBase, Interfaces.IELFacilityLicensing
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELFacilityLicensing";

        // ContinuingLicenseDate -- (backing property for Continuing License Date)
        private System.DateTime? _ContinuingLicenseDate;

        // InitialLicensingDate -- (backing property for Initial License Date)
        private System.DateTime? _InitialLicensingDate;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefELFacilityLicensingStatusId -- (backing property for Facility Licensing Status)
        private Guid? _RefELFacilityLicensingStatusId;

        // RefLicenseExemptId -- (backing property for License Exempt)
        private Guid? _RefLicenseExemptId;

        // StateLicensedFacilityCapacity -- (backing property for State Licensed Facility Capacity)
        private System.Int32? _StateLicensedFacilityCapacity;

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
        public System.DateTime? InitialLicensingDate { get => _InitialLicensingDate; set => SetProperty(ref _InitialLicensingDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Facility Licensing Status
        /// <para>
        /// The status of the facility license.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19985">Facility Licensing Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefELFacilityLicensingStatusId { get => _RefELFacilityLicensingStatusId; set => SetProperty(ref _RefELFacilityLicensingStatusId, value); }

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

        /// <summary>
        /// State Licensed Facility Capacity
        /// <para>
        /// The maximum number of children for which a state licensed a facility.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19865">State Licensed Facility Capacity</a>
        /// </para>
        /// </summary>
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
            ContinuingLicenseDate = model.ContinuingLicenseDate; // Continuing License Date
            InitialLicensingDate = model.InitialLicensingDate; // Initial License Date
            OrganizationId = model.OrganizationId; // 
            RefELFacilityLicensingStatusId = model.RefELFacilityLicensingStatusId; // Facility Licensing Status
            RefLicenseExemptId = model.RefLicenseExemptId; // License Exempt
            StateLicensedFacilityCapacity = model.StateLicensedFacilityCapacity; // State Licensed Facility Capacity
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefLicenseExempt List
        /// <summary>
        /// The complete Continuing License Date List
        /// </summary>
        private static List<ReferenceModelBase> RefLicenseExemptList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("c1a8e558-bd18-4320-b7e0-4195d4b84bb0"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("4db00c76-9655-4aaf-8eaf-01d8eb454680"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("df139e78-59ea-4895-8849-96b6e03c40aa"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };
        #endregion
    }
}
