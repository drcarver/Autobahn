//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAuthorization.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Authorization
{
     /// <summary>
     /// The IAuthorization Interface
     /// </summary>
    public partial interface IAuthorization : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IApplication"/> model
        /// </summary>
        Guid? ApplicationId { get; set; }

        /// <summary>
        /// Authorization Application Role Name
        /// <para>
        /// The user role for which the person is allowed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20129">Authorization Application Role Name</a>
        /// </para>
        /// </summary>
        System.String ApplicationRoleName { get; set; }

        /// <summary>
        /// Authorization End Date
        /// <para>
        /// The date after which the  an associated person is no longer allowed to use the application with the specified role.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20131">Authorization End Date</a>
        /// </para>
        /// </summary>
        DateTime? EndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Authorization Start Date
        /// <para>
        /// The date on which the  an associated person  is authorized to start using the application with the specified role.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20130">Authorization Start Date</a>
        /// </para>
        /// </summary>
        DateTime? StartDate { get; set; }

    }
}
