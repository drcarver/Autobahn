//**********************************************************
//* DomainName: Facilities
//* FileName:   FacilityRelationshipModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Facilities;

namespace Autobahn.Education.Facilities.Models
{
     /// <summary>
     /// The FacilityRelationship Model
     /// </summary>
    public partial class FacilityRelationshipModel : IFacilityRelationship
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

        #region IFacilityRelationship
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        public Guid FacilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IParentFacility"/> model
        /// </summary>
        public Guid ParentFacilityId { get; set; }

        #endregion
    }
}
