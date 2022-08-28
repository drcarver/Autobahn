//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionLocationModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Postsecondary;

namespace Autobahn.Education.Postsecondary.Models
{
     /// <summary>
     /// The PsSectionLocation Model
     /// </summary>
    public partial class PsSectionLocationModel : IPsSectionLocation
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

        #region IPsSectionLocation
        /// <summary>
        /// Course Instruction Site Name
        /// <para>
        /// The name of the location at which the course is taught.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20275">Course Instruction Site Name</a>
        /// </para>
        /// </summary>
        public System.String CourseInstructionSiteName { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPsSection"/> model
        /// </summary>
        public Guid PsSectionId { get; set; }

        /// <summary>
        /// Course Instruction Site Type
        /// <para>
        /// An indication of the type of location at which the course is taught.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20276">Course Instruction Site Type</a>
        /// </para>
        /// </summary>
        public Guid? RefCourseInstructionSiteTypeId { get; set; }

        #endregion
    }
}
