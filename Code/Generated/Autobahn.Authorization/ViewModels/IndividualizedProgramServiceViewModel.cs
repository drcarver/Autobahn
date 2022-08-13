//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   IndividualizedProgramServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramServiceViewModel
     /// </summary>
    public partial class IndividualizedProgramServiceViewModel : ViewModelBase, Interfaces.IIndividualizedProgramService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramService";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the PlannedServiceDuration property
        private System.Decimal? _PlannedServiceDuration;

        // member variable for the PlannedServiceStartDate property
        private System.DateTime? _PlannedServiceStartDate;

        // member variable for the RefIndividualizedProgramPlannedServiceTypeId property
        private Guid? _RefIndividualizedProgramPlannedServiceTypeId;

        // member variable for the RefMethodOfServiceDeliveryId property
        private Guid? _RefMethodOfServiceDeliveryId;

        // member variable for the RefServiceFrequencyId property
        private Guid? _RefServiceFrequencyId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramServiceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// The date the service is planned to begin.
        /// </summary>
        public System.Decimal? PlannedServiceDuration { get => _PlannedServiceDuration; set => SetProperty(ref _PlannedServiceDuration, value); }

        /// <summary>
        /// The date the service is planned to begin.
        /// </summary>
        public System.DateTime? PlannedServiceStartDate { get => _PlannedServiceStartDate; set => SetProperty(ref _PlannedServiceStartDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndividualizedProgramPlannedServiceType"/> model
        /// </summary>
        public Guid? RefIndividualizedProgramPlannedServiceTypeId { get => _RefIndividualizedProgramPlannedServiceTypeId; set => SetProperty(ref _RefIndividualizedProgramPlannedServiceTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMethodOfServiceDelivery"/> model
        /// </summary>
        public Guid? RefMethodOfServiceDeliveryId { get => _RefMethodOfServiceDeliveryId; set => SetProperty(ref _RefMethodOfServiceDeliveryId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefServiceFrequency"/> model
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
            PersonId = model.PersonId;
            PlannedServiceDuration = model.PlannedServiceDuration;
            PlannedServiceStartDate = model.PlannedServiceStartDate;
            RefIndividualizedProgramPlannedServiceTypeId = model.RefIndividualizedProgramPlannedServiceTypeId;
            RefMethodOfServiceDeliveryId = model.RefMethodOfServiceDeliveryId;
            RefServiceFrequencyId = model.RefServiceFrequencyId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
