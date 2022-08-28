//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPersonRole.cs
//***************************************************************************

namespace Autobahn.Education.Interfaces.Common
{
     /// <summary>
     /// The IOrganizationPersonRole Interface
     /// </summary>
    public partial interface IOrganizationPersonRole : IAutobahnBase
    {
        #region IOrganizationPersonRole
        /// <summary>
        /// Activity Involvement Begin Date
        /// <para>
        /// The year, month and day on which the person began to participate in the activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19007">Activity Involvement Begin Date</a>
        /// </para>
        /// </summary>
        DateTime? EntryDate { get; set; }

        /// <summary>
        /// Activity Involvement End Date
        /// <para>
        /// The year, month and day on which the person ceased to participate in the activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19008">Activity Involvement End Date</a>
        /// </para>
        /// </summary>
        DateTime? ExitDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRole"/> model
        /// </summary>
        Guid RoleId { get; set; }

        #endregion
    }
}
