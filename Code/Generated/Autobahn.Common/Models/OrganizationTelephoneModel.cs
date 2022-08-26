//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTelephoneModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationTelephone Model
     /// </summary>
    public partial class OrganizationTelephoneModel : AutobahnBase, IOrganizationTelephone
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
        public Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Primary Telephone Number Indicator
        /// <para>
        /// An indication that the telephone number should be used as the principal number for a person or organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19219">Primary Telephone Number Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

        /// <summary>
        /// Institution Telephone Number Type
        /// <para>
        /// The type of communication number listed for an organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19167">Institution Telephone Number Type</a>
        /// </para>
        /// </summary>
        public Guid? RefInstitutionTelephoneTypeId { get; set; }

        /// <summary>
        /// Telephone Number Listed Status
        /// <para>
        /// An indication of whether a telephone number is listed under a directory assistance service.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20911">Telephone Number Listed Status</a>
        /// </para>
        /// </summary>
        public Guid? RefTelephoneNumberListedStatusId { get; set; }

        /// <summary>
        /// Telephone Number
        /// <para>
        /// The telephone number including the area code, and extension, if applicable.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19279">Telephone Number</a>
        /// </para>
        /// </summary>
        public System.String TelephoneNumber { get; set; }

    }
}
