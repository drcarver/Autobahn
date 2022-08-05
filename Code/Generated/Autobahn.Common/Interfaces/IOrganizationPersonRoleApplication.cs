//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationPersonRoleApplication.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRoleApplication
     /// </summary>
    public partial interface IOrganizationPersonRoleApplication : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Defines the OrganizationPersonRoleApplication.ApplicationDate non nullable property
        /// </summary>
        System.DateTime ApplicationDate { get; set; }

    }
}
