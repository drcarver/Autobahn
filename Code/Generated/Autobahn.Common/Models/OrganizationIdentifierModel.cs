//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIdentifierModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationIdentifier Model
     /// </summary>
    public partial class OrganizationIdentifierModel : AutobahnBase, Interfaces.IOrganizationIdentifier
    {
        /// <summary>
        /// A unique number or alphanumeric code used in the local system to identify an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// </summary>
        public Guid? RefOrganizationIdentifierTypeId { get; set; }

    }
}
