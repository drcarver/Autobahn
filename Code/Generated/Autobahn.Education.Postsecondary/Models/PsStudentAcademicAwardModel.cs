//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicAwardModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Postsecondary;

namespace Autobahn.Education.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentAcademicAward Model
     /// </summary>
    public partial class PsStudentAcademicAwardModel : IPsStudentAcademicAward
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

        #region IPsStudentAcademicAward
        /// <summary>
        /// Academic Award Date
        /// <para>
        /// The year, month and day or year and month on which the academic award was conferred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19001">Academic Award Date</a>
        /// </para>
        /// </summary>
        public System.String AcademicAwardDate { get; set; }

        /// <summary>
        /// Academic Award Title
        /// <para>
        /// The descriptive title for the academic award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19003">Academic Award Title</a>
        /// </para>
        /// </summary>
        public System.String AcademicAwardTitle { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Academic Award Level Conferred
        /// <para>
        /// An indicator of the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study.   
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19002">Academic Award Level Conferred</a>
        /// </para>
        /// </summary>
        public Guid? RefAcademicAwardLevelId { get; set; }

        /// <summary>
        /// Academic Award Prerequisite Type
        /// <para>
        /// Prerequisite conditions for earning an academic award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20647">Academic Award Prerequisite Type</a>
        /// </para>
        /// </summary>
        public Guid? RefAcademicAwardPrerequisiteTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPescawardLevelType"/> model
        /// </summary>
        public Guid? RefPescawardLevelTypeId { get; set; }

        public System.String RequirementsUrl { get; set; }

        #endregion
    }
}
