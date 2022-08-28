//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleStatusModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The RoleStatus Model
     /// </summary>
    public partial class RoleStatusModel : IRoleStatus
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

        #region IRoleStatus
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Enrollment Status
        /// <para>
        /// An indication as to whether a student's name was, is, or will be officially registered on the roll of a school or schools.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19094">Enrollment Status</a>
        /// </para>
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
        public DateTime? StatusEndDate { get; set; }

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

        #endregion
    }
}
