//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationDetailModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationDetail Model
     /// </summary>
    public partial class OrganizationDetailModel : AutobahnBase, Interfaces.IOrganizationDetail
    {
        /// <summary>
        /// The name of a data system or application which an authenticated person may access.
        /// </summary>
        public System.String Name { get; set; }

    }
}
