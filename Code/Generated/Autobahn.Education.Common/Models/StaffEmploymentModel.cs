//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEmploymentModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The StaffEmployment Model
     /// </summary>
    public partial class StaffEmploymentModel : IStaffEmployment
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

        #region IStaffEmployment
        /// <summary>
        /// Staff Full Time Equivalency
        /// <para>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19118">Staff Full Time Equivalency</a>
        /// </para>
        /// </summary>
        public Decimal? FullTimeEquivalency { get; set; }

        /// <summary>
        /// Hire Date
        /// <para>
        /// The year, month and day on which a person was hired for a position, or consecutive positions within the same organization and job classification.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19143">Hire Date</a>
        /// </para>
        /// </summary>
        public DateTime? HireDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Position Title
        /// <para>
        /// The descriptive name of a person's position.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19213">Position Title</a>
        /// </para>
        /// </summary>
        public System.String PositionTitle { get; set; }

        /// <summary>
        /// Employment Separation Reason
        /// <para>
        /// The primary reason for the termination of the employment relationship.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19613">Employment Separation Reason</a>
        /// </para>
        /// </summary>
        public Guid? RefEmploymentSeparationReasonId { get; set; }

        /// <summary>
        /// Employment Separation Type
        /// <para>
        /// A designation of the type of separation occurring between a person and the organization.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19614">Employment Separation Type</a>
        /// </para>
        /// </summary>
        public Guid? RefEmploymentSeparationTypeId { get; set; }

        /// <summary>
        /// Standard Occupational Classification
        /// <para>
        /// A Bureau of Labor Statistics coding system for classifying occupations by work performed and, in some cases, on the skills, education and training needed to perform the work at a competent level.  See https://www.bls.gov/soc/2018/major_groups.htm.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19707">Standard Occupational Classification</a>
        /// </para>
        /// </summary>
        public System.String StandardOccupationalClassification { get; set; }

        /// <summary>
        /// Union Membership Name
        /// <para>
        /// The name of the labor organization of which the person is a member.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20469">Union Membership Name</a>
        /// </para>
        /// </summary>
        public System.String UnionMembershipName { get; set; }

        /// <summary>
        /// Weeks Employed Per Year
        /// <para>
        /// The number of weeks employed by year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20470">Weeks Employed Per Year</a>
        /// </para>
        /// </summary>
        public Int32? WeeksEmployedPerYear { get; set; }

        #endregion
    }
}