//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationServiceModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationServiceModel Interface
     /// </summary>
    public partial interface IOrganizationServiceModel : IAutobahnBase
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
