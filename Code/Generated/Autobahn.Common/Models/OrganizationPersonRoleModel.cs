//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The OrganizationPersonRole Model
     /// </summary>
    public partial class OrganizationPersonRoleModel : AutobahnBase, Interfaces.IOrganizationPersonRole
    {
        /// <summary>
        /// Activity Involvement Begin Date
        /// <para>
        /// The year, month and day on which the person began to participate in the activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19007">Activity Involvement Begin Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? EntryDate { get; set; }

        /// <summary>
        /// Activity Involvement End Date
        /// <para>
        /// The year, month and day on which the person ceased to participate in the activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19008">Activity Involvement End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? ExitDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRole"/> model
        /// </summary>
        public Guid RoleId { get; set; }

    }
}
