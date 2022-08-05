//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationService.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationService
     /// </summary>
    public partial interface IOrganizationService : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefStudentSupportServiceType"/> model
        /// </summary>
        Guid RefStudentSupportServiceTypeId { get; set; }

    }
}
