//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaTitleIiiprofessionalDevelopmentModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.K12;

namespace Autobahn.Education.K12.Models
{
     /// <summary>
     /// The K12leaTitleIiiprofessionalDevelopment Model
     /// </summary>
    public partial class K12leaTitleIiiprofessionalDevelopmentModel : IK12leaTitleIiiprofessionalDevelopment
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

        #region IK12leaTitleIiiprofessionalDevelopment
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        public Guid K12leaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12leatitleIiiprofessionalDevelopment"/> model
        /// </summary>
        public Guid K12leatitleIiiprofessionalDevelopmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIiiprofessionalDevelopmentType"/> model
        /// </summary>
        public Guid RefTitleIiiprofessionalDevelopmentTypeId { get; set; }

        #endregion
    }
}
