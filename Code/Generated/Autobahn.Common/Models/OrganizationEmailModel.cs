//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmailModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationEmail Model
     /// </summary>
    public partial class OrganizationEmailModel : AutobahnBase, Interfaces.IOrganizationEmail
    {
        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        public System.String ElectronicMailAddress { get; set; }

    }
}
