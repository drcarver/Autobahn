//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationPersonRoleApplicationModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPersonRoleApplicationModel Interface
     /// </summary>
    public partial interface IOrganizationPersonRoleApplicationModel : IAutobahnBase
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
