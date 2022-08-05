//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefOrganizationMonitoringNotification.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefOrganizationMonitoringNotification Interface
     /// </summary>
    public partial interface IRefOrganizationMonitoringNotification : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
        /// </summary>
        Guid RefOrganizationMonitoringNotificationsId { get; set; }

    }
}
