//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaSafeDrugFreeModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.K12;

namespace Autobahn.Education.K12.Models
{
     /// <summary>
     /// The K12leaSafeDrugFree Model
     /// </summary>
    public partial class K12leaSafeDrugFreeModel : IK12leaSafeDrugFree
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

        #region IK12leaSafeDrugFree
        public System.String Baseline { get; set; }

        public System.String BaselineYear { get; set; }

        public System.String CollectionFrequency { get; set; }

        public System.String IndicatorName { get; set; }

        public System.String Instrument { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        public Guid K12leaId { get; set; }

        public System.String MostRecentCollection { get; set; }

        public System.String Performance { get; set; }

        public System.String Target { get; set; }

        #endregion
    }
}
