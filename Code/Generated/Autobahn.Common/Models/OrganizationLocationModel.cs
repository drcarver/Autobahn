//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationLocationModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationLocation Model
     /// </summary>
    public partial class OrganizationLocationModel : AutobahnBase, Interfaces.IOrganizationLocation
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILocation"/> model
        /// </summary>
        public Guid LocationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationLocationType"/> model
        /// </summary>
        public Guid? RefOrganizationLocationTypeId { get; set; }

    }
}
