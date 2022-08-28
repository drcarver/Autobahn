//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Authorization;

namespace Autobahn.Education.Authorization.Models
{
     /// <summary>
     /// The Authorization Model
     /// </summary>
    public partial class AuthorizationModel : IAuthorization
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IAuthorization
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
        public DateTime? EndDate { get; set; }

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
        public DateTime? StartDate { get; set; }

        #endregion
    }
}
