//**********************************************************
//* DomainName: Learning Resources
//* FileName:   PeerRatingSystemModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.LearningResources;

namespace Autobahn.Education.LearningResources.Models
{
     /// <summary>
     /// The PeerRatingSystem Model
     /// </summary>
    public partial class PeerRatingSystemModel : IPeerRatingSystem
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

        #region IPeerRatingSystem
        /// <summary>
        /// Peer Rating System Maximum Value
        /// <para>
        ///  The maximum value allowed by the Peer Rating System.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20162">Peer Rating System Maximum Value</a>
        /// </para>
        /// </summary>
        public Decimal? MaximumValue { get; set; }

        /// <summary>
        /// Peer Rating System Minimum Value
        /// <para>
        /// The minimum value allowed by the Peer Rating System.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20163">Peer Rating System Minimum Value</a>
        /// </para>
        /// </summary>
        public System.Decimal MinimumValue { get; set; }

        /// <summary>
        /// Peer Rating System Name
        /// <para>
        /// The name of the scaling system used to specify the Peer Rating.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20160">Peer Rating System Name</a>
        /// </para>
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Peer Rating System Optimum Value
        /// <para>
        /// The optimum value allowed by the Peer Rating System.  The optimum or best rating may be the maximum value, the minimum value, or something in between.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20164">Peer Rating System Optimum Value</a>
        /// </para>
        /// </summary>
        public Decimal? OptimumValue { get; set; }

        #endregion
    }
}
