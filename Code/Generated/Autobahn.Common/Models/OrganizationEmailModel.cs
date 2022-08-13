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
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        public System.String ElectronicMailAddress { get; set; }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        public Guid? RefEmailTypeId { get; set; }

    }
}
