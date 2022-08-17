//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationOperationalStatusModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The OrganizationOperationalStatus Model
     /// </summary>
    public partial class OrganizationOperationalStatusModel : AutobahnBase, Interfaces.IOrganizationOperationalStatus
    {
        /// <summary>
        /// Operation Date
        /// <para>
        /// The year, month and day on which a program or center began operation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19350">Operation Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? OperationalStatusEffectiveDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefOperationalStatus"/> model
        /// </summary>
        public Guid RefOperationalStatusId { get; set; }

    }
}
