//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediumModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.LearningResources;

namespace Autobahn.Education.LearningResources.Models
{
     /// <summary>
     /// The LearningResourcePhysicalMedium Model
     /// </summary>
    public partial class LearningResourcePhysicalMediumModel : ILearningResourcePhysicalMedium
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

        #region ILearningResourcePhysicalMedium
        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResourcePhysicalMedia"/> model
        /// </summary>
        public Guid LearningResourcePhysicalMediaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourcePhysicalMediaType"/> model
        /// </summary>
        public Guid RefLearningResourcePhysicalMediaTypeId { get; set; }

        #endregion
    }
}
