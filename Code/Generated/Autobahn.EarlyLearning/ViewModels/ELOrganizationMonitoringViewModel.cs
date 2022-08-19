//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELOrganizationMonitoringViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELOrganizationMonitoring View Model
     /// </summary>
    public partial class ELOrganizationMonitoringViewModel : ViewModelBase, Interfaces.IELOrganizationMonitoring
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELOrganizationMonitoring";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefOrganizationMonitoringNotificationsId -- (backing property for Organization Monitoring Notifications)
        private Guid? _RefOrganizationMonitoringNotificationsId;

        // RefPurposeOfMonitoringVisitId -- (backing property for Purpose of Monitoring Visit)
        private Guid? _RefPurposeOfMonitoringVisitId;

        // TypeOfMonitoring -- (backing property for Organization Type of Monitoring)
        private System.String _TypeOfMonitoring;

        // VisitEndDate -- (backing property for Monitoring Visit End Date)
        private System.DateTime? _VisitEndDate;

        // VisitStartDate -- (backing property for Monitoring Visit Start Date)
        private System.DateTime? _VisitStartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Organization Monitoring Notifications
        /// <para>
        /// Whether the organization received notification about monitoring
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20296">Organization Monitoring Notifications</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefOrganizationMonitoringNotificationsId { get => _RefOrganizationMonitoringNotificationsId; set => SetProperty(ref _RefOrganizationMonitoringNotificationsId, value); }

        /// <summary>
        /// Purpose of Monitoring Visit
        /// <para>
        /// The purpose for the monitoring visit.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20299">Purpose of Monitoring Visit</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPurposeOfMonitoringVisitId { get => _RefPurposeOfMonitoringVisitId; set => SetProperty(ref _RefPurposeOfMonitoringVisitId, value); }

        /// <summary>
        /// Organization Type of Monitoring
        /// <para>
        /// The type of monitoring on the organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20300">Organization Type of Monitoring</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String TypeOfMonitoring { get => _TypeOfMonitoring; set => SetProperty(ref _TypeOfMonitoring, value); }

        /// <summary>
        /// Monitoring Visit End Date
        /// <para>
        /// The date that monitoring visit ended.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20298">Monitoring Visit End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? VisitEndDate { get => _VisitEndDate; set => SetProperty(ref _VisitEndDate, value); }

        /// <summary>
        /// Monitoring Visit Start Date
        /// <para>
        /// The date that monitoring visit began.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20297">Monitoring Visit Start Date</a>
        /// </para>
        /// </summary>
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
            OrganizationId = model.OrganizationId; // 
            RefOrganizationMonitoringNotificationsId = model.RefOrganizationMonitoringNotificationsId; // Organization Monitoring Notifications
            RefPurposeOfMonitoringVisitId = model.RefPurposeOfMonitoringVisitId; // Purpose of Monitoring Visit
            TypeOfMonitoring = model.TypeOfMonitoring; // Organization Type of Monitoring
            VisitEndDate = model.VisitEndDate; // Monitoring Visit End Date
            VisitStartDate = model.VisitStartDate; // Monitoring Visit Start Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefOrganizationMonitoringNotifications List
        /// <summary>
        /// The complete <see cref="RefOrganizationMonitoringNotifications"> List
        /// </summary>
        private static List<ReferenceModelBase> RefOrganizationMonitoringNotificationsList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("9ffa0b33-3466-4950-911f-99f7b8f3c675"), Code="Announced", Description="Announced", Definition="The organization received notification about monitoring.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("34b4b3f3-57a7-4957-956b-b67183fd40e5"), Code="Unannounced", Description="Unannounced", Definition="The organization did not received notification about monitoring.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefPurposeOfMonitoringVisit List
        /// <summary>
        /// The complete <see cref="RefPurposeOfMonitoringVisit"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPurposeOfMonitoringVisitList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("17710df6-e87a-440b-b94b-f1b45b1d6292"), Code="LicensingVisits", Description="Licensing Visits", Definition="The monitoring visit is for licensing.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("122118dc-4f86-46f8-8e45-92cc86c7a412"), Code="HeathSafety", Description="Health and Safety", Definition="The monitoring visit is for Health and Safety.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("bef41eec-4473-4903-bf81-0656688dde37"), Code="Renewal", Description="Renewal", Definition="The monitoring visit is for Renewal.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("9a036bd9-946b-4dea-a317-291db11073ea"), Code="Review", Description="Review", Definition="The monitoring visit is for Review.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("6876eb7b-abb5-4ebb-84cc-282437517c34"), Code="Other", Description="Other", Definition="The monitoring visit is for Other.", SortOrder=Convert.ToDecimal("9.00") },
        };
        #endregion
    }
}
