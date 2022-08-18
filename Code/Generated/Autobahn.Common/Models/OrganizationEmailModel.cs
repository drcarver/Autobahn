//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmailModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationEmail Model
     /// </summary>
    public partial class OrganizationEmailModel : AutobahnBase, Interfaces.IOrganizationEmail
    {
        /// <summary>
        /// Do Not Publish Indicator
        /// <para>
        /// An indication that the record should not be published.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Electronic Mail Address
        /// <para>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19088">Electronic Mail Address</a>
        /// </para>
        /// </summary>
        public System.String ElectronicMailAddress { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmailType"/> model
        /// </summary>
        public Guid? RefEmailTypeId { get; set; }

    }
}
