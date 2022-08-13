//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPersonRoleApplication.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRoleApplication Interface
     /// </summary>
    public partial interface IOrganizationPersonRoleApplication : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        System.DateTime ApplicationDate { get; set; }

        /// <summary>
        /// The year, month and day on which an individual  application is received by the organization.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

    }
}
