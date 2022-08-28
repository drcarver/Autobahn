//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaPreKeligibleAgesIdeaModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.K12;

namespace Autobahn.Education.K12.Models
{
     /// <summary>
     /// The K12leaPreKeligibleAgesIdea Model
     /// </summary>
    public partial class K12leaPreKeligibleAgesIdeaModel : IK12leaPreKeligibleAgesIdea
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

        #region IK12leaPreKeligibleAgesIdea
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        public Guid K12leaId { get; set; }

        public System.Int32 K12leapreKeligibleAgesIdeaid { get; set; }

        public System.Int32 RefPreKeligibleAgesNonIdeaid { get; set; }

        #endregion
    }
}
