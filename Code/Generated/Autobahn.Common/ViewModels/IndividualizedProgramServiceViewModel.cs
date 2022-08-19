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
            new ReferenceModelBase { Id=Guid.Parse("8ec103a9-2288-4c7e-a47f-1cc3e0b3c60c"), Code="Individual", Description="Individual", Definition="The services will be provided individually.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("e378daae-56a9-4380-ba24-969a3953bb1b"), Code="Group", Description="Group", Definition="The services will be provided in a group.", SortOrder=Convert.ToDecimal("4.00") },
        };
        #endregion

        #region RefServiceFrequency List
        /// <summary>
        /// The complete <see cref="RefServiceFrequency"> List
        /// </summary>
        private static List<ReferenceModelBase> RefServiceFrequencyList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("90d35baf-6688-4ac6-b285-f494ae26968f"), Code="Daily", Description="Daily", Definition="The service is planned to be provided Daily.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("bd70aeb8-817f-47c2-9571-8733c4c1dc85"), Code="Weekly", Description="Weekly", Definition="The service is planned to be provided Weekly.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("9346d9be-5402-49ab-8ab6-d41899c72a7b"), Code="Biweekly", Description="Biweekly", Definition="The service is planned to be provided Biweekly.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("18375dad-5b4e-49fb-9b05-9c06f3bc4814"), Code="Monthly", Description="Monthly", Definition="The service is planned to be provided Monthly.", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("796e2760-19ab-498c-9bcd-246a4c1f60fb"), Code="Bimonthly", Description="Bimonthly", Definition="The service is planned to be provided Bimonthly.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("24db8b65-8b93-4c75-983e-ad0bc39b4816"), Code="Quarterly", Description="Quarterly", Definition="The service is planned to be provided Quarterly.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("dcd24660-5370-4f9a-8728-627dbecd3e05"), Code="Semiannually", Description="Semiannually", Definition="The service is planned to be provided Semiannually.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("b0334dd7-ddb0-4c55-aa6c-20e8ab2e7223"), Code="Annually", Description="Annually", Definition="The service is planned to be provided Annually.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("b6143417-caf9-42b5-8ce7-af67eaf591c4"), Code="Other", Description="Other", Definition="The service is planned to be provided at a frequency not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };
        #endregion
    }
}
