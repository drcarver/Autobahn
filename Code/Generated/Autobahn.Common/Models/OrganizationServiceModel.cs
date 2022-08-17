//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationServiceModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The OrganizationService Model
     /// </summary>
    public partial class OrganizationServiceModel : AutobahnBase, Interfaces.IOrganizationService
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefStudentSupportServiceType"/> model
        /// </summary>
        public Guid RefStudentSupportServiceTypeId { get; set; }

    }
}
