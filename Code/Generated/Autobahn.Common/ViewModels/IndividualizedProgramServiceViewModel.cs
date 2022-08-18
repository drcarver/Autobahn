//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramServiceViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramService View Model
     /// </summary>
    public partial class IndividualizedProgramServiceViewModel : ViewModelBase, Interfaces.IIndividualizedProgramService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramService";

        // member variable for the PersonId property
        private Guid _PersonId;

        // PlannedServiceDuration -- (backing property for Individualized Program Planned Service Duration)
        private System.Decimal? _PlannedServiceDuration;

        // PlannedServiceStartDate -- (backing property for Individualized Program Planned Service Start Date)
        private System.DateTime? _PlannedServiceStartDate;

        // RefIndividualizedProgramPlannedServiceTypeId -- (backing property for Individualized Program Planned Service Type)
        private Guid? _RefIndividualizedProgramPlannedServiceTypeId;

        // RefMethodOfServiceDeliveryId -- (backing property for Method of Service Delivery)
        private Guid? _RefMethodOfServiceDeliveryId;

        // RefServiceFrequencyId -- (backing property for Individualized Program Planned Service Frequency)
        private Guid? _RefServiceFrequencyId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Individualized Program Planned Service Duration
        /// <para>
        /// The length, in hours, that delivery of the service is planned.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20493">Individualized Program Planned Service Duration</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? PlannedServiceDuration { get => _PlannedServiceDuration; set => SetProperty(ref _PlannedServiceDuration, value); }

        /// <summary>
        /// Individualized Program Planned Service Start Date
        /// <para>
        /// The date the service is planned to begin.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20350">Individualized Program Planned Service Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? PlannedServiceStartDate { get => _PlannedServiceStartDate; set => SetProperty(ref _PlannedServiceStartDate, value); }

        /// <summary>
        /// Individualized Program Planned Service Type
        /// <para>
        /// The types of service that adapts the curriculum, materials, or instruction for students identified as needing special education because of a delay or disability.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20352">Individualized Program Planned Service Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIndividualizedProgramPlannedServiceTypeId { get => _RefIndividualizedProgramPlannedServiceTypeId; set => SetProperty(ref _RefIndividualizedProgramPlannedServiceTypeId, value); }

        /// <summary>
        /// Method of Service Delivery
        /// <para>
        /// The method by which the services will be provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20482">Method of Service Delivery</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMethodOfServiceDeliveryId { get => _RefMethodOfServiceDeliveryId; set => SetProperty(ref _RefMethodOfServiceDeliveryId, value); }

        /// <summary>
        /// Individualized Program Planned Service Frequency
        /// <para>
        /// The frequency that a service is planned to be provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20492">Individualized Program Planned Service Frequency</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefServiceFrequencyId { get => _RefServiceFrequencyId; set => SetProperty(ref _RefServiceFrequencyId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramService model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId; // 
            PlannedServiceDuration = model.PlannedServiceDuration; // Individualized Program Planned Service Duration
            PlannedServiceStartDate = model.PlannedServiceStartDate; // Individualized Program Planned Service Start Date
            RefIndividualizedProgramPlannedServiceTypeId = model.RefIndividualizedProgramPlannedServiceTypeId; // Individualized Program Planned Service Type
            RefMethodOfServiceDeliveryId = model.RefMethodOfServiceDeliveryId; // Method of Service Delivery
            RefServiceFrequencyId = model.RefServiceFrequencyId; // Individualized Program Planned Service Frequency
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefMethodOfServiceDelivery List
        /// <summary>
        /// The complete <see cref="RefMethodOfServiceDelivery"> List
        /// </summary>
        private static List<ReferenceModelBase> RefMethodOfServiceDeliveryList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("2d127b2f-0aad-4f34-bd72-7367eb8bb8ec"), Code="Individual", Description="Individual", Definition="The services will be provided individually.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("f2a71313-5ccb-44cc-a03d-18dc91706984"), Code="Group", Description="Group", Definition="The services will be provided in a group.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion

        #region RefServiceFrequency List
        /// <summary>
        /// The complete <see cref="RefServiceFrequency"> List
        /// </summary>
        private static List<ReferenceModelBase> RefServiceFrequencyList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("fcecf238-741e-44ac-8119-a19bfe4a750c"), Code="Daily", Description="Daily", Definition="The service is planned to be provided Daily.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("d75b853b-bdac-45e0-81ba-f0de31c1ed5a"), Code="Weekly", Description="Weekly", Definition="The service is planned to be provided Weekly.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("101f00d1-0055-4d09-8cc6-a24ee2c9de25"), Code="Biweekly", Description="Biweekly", Definition="The service is planned to be provided Biweekly.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("2f9e5cc0-67bd-4a32-9e83-06f584a6da42"), Code="Monthly", Description="Monthly", Definition="The service is planned to be provided Monthly.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("85b995d8-ddc3-4ca2-9340-baa27b80323d"), Code="Bimonthly", Description="Bimonthly", Definition="The service is planned to be provided Bimonthly.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("2bd42f1d-0b08-462c-861e-ee834ed6f293"), Code="Quarterly", Description="Quarterly", Definition="The service is planned to be provided Quarterly.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("674a3ba6-ce79-46c1-84d9-2ed13dbf9204"), Code="Semiannually", Description="Semiannually", Definition="The service is planned to be provided Semiannually.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("4012a524-8798-4045-a653-a2789eb80373"), Code="Annually", Description="Annually", Definition="The service is planned to be provided Annually.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("0f198be6-5f4f-4a4e-8165-d1cdd3486593"), Code="Other", Description="Other", Definition="The service is planned to be provided at a frequency not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion
    }
}
