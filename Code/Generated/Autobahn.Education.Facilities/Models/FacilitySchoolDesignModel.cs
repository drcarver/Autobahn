//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilitySchoolDesignModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Facilities;

namespace Autobahn.Education.Facilities.Models
{
     /// <summary>
     /// The FacilitySchoolDesign Model
     /// </summary>
    public partial class FacilitySchoolDesignModel : IFacilitySchoolDesign
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

        #region IFacilitySchoolDesign
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacilityDesign"/> model
        /// </summary>
        public Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Building School Design Type
        /// <para>
        /// The physical layout and character of a school facility, as determined by age groups served and educational programs provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20809">Building School Design Type</a>
        /// </para>
        /// </summary>
        public Guid RefBuildingSchoolDesignTypeId { get; set; }

        #endregion
    }
}
