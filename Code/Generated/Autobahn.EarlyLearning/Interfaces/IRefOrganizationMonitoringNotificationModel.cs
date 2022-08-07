//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IRefOrganizationMonitoringNotificationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The RefOrganizationMonitoringNotification Interface Model
     /// </summary>
    public partial interface IRefOrganizationMonitoringNotificationModel : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefOrganizationMonitoringNotifications"/> model
        /// </summary>
        Guid RefOrganizationMonitoringNotificationsId { get; set; }

    }
}
