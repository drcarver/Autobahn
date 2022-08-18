//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleStatusModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RoleStatus Model
     /// </summary>
    public partial class RoleStatusModel : AutobahnBase, Interfaces.IRoleStatus
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRoleStatus"/> model
        /// </summary>
        public Guid? RefRoleStatusId { get; set; }

        /// <summary>
        /// Employment End Date
        /// <para>
        /// The year, month and day on which a person ended self-employment or employment with an organization or institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19794">Employment End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// Employment Start Date
        /// <para>
        /// The year, month and day on which a person began self-employment or employment with an organization or institution.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19345">Employment Start Date</a>
        /// </para>
        /// </summary>
        public System.DateTime StatusStartDate { get; set; }

    }
}
