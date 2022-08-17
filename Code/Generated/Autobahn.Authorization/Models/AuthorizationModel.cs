//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The Authorization Model
     /// </summary>
    public partial class AuthorizationModel : AutobahnBase, Interfaces.IAuthorization
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IApplication"/> model
        /// </summary>
        public Guid? ApplicationId { get; set; }

        /// <summary>
        /// Authorization Application Role Name
        /// <para>
        /// The user role for which the person is allowed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20129">Authorization Application Role Name</a>
        /// </para>
        /// </summary>
        public System.String ApplicationRoleName { get; set; }

        /// <summary>
        /// Authorization End Date
        /// <para>
        /// The date after which the  an associated person is no longer allowed to use the application with the specified role.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20131">Authorization End Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Authorization Start Date
        /// <para>
        /// The date on which the  an associated person  is authorized to start using the application with the specified role.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20130">Authorization Start Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? StartDate { get; set; }

    }
}
