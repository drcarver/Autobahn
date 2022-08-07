//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationEmailModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationEmail Model
     /// </summary>
    public partial class OrganizationEmailModel : AutobahnBase, Interfaces.IOrganizationEmailModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationEmail.ElectronicMailAddress non nullable property
        /// </summary>
        public System.String ElectronicMailAddress { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmailType"/> model
        /// </summary>
        public Guid? RefEmailTypeId { get; set; }

        /// <summary>
        /// Defines the OrganizationEmail.DoNotPublishIndicator nullable property
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
