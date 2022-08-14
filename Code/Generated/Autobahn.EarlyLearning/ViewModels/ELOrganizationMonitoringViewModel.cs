//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationMonitoringViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELOrganizationMonitoringViewModel
     /// </summary>
    public partial class ELOrganizationMonitoringViewModel : ViewModelBase, Interfaces.IELOrganizationMonitoring
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganizationMonitoring";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the RefOrganizationMonitoringNotificationsId property
        private Guid? _RefOrganizationMonitoringNotificationsId;

        // member variable for the RefPurposeOfMonitoringVisitId property
        private Guid? _RefPurposeOfMonitoringVisitId;

        // member variable for the TypeOfMonitoring property
        private System.String _TypeOfMonitoring;

        // member variable for the VisitEndDate property
        private System.DateTime? _VisitEndDate;

        // member variable for the VisitStartDate property
        private System.DateTime? _VisitStartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELOrganizationMonitoringViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
        /// </summary>
        public Guid? RefOrganizationMonitoringNotificationsId { get => _RefOrganizationMonitoringNotificationsId; set => SetProperty(ref _RefOrganizationMonitoringNotificationsId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPurposeOfMonitoringVisit"/> model
        /// </summary>
        public Guid? RefPurposeOfMonitoringVisitId { get => _RefPurposeOfMonitoringVisitId; set => SetProperty(ref _RefPurposeOfMonitoringVisitId, value); }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        public System.String TypeOfMonitoring { get => _TypeOfMonitoring; set => SetProperty(ref _TypeOfMonitoring, value); }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        public System.DateTime? VisitEndDate { get => _VisitEndDate; set => SetProperty(ref _VisitEndDate, value); }

        /// <summary>
        /// Whether the organization received notification about monitoring
        /// </summary>
        public System.DateTime? VisitStartDate { get => _VisitStartDate; set => SetProperty(ref _VisitStartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELOrganizationMonitoring model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            RefOrganizationMonitoringNotificationsId = model.RefOrganizationMonitoringNotificationsId;
            RefPurposeOfMonitoringVisitId = model.RefPurposeOfMonitoringVisitId;
            TypeOfMonitoring = model.TypeOfMonitoring;
            VisitEndDate = model.VisitEndDate;
            VisitStartDate = model.VisitStartDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
