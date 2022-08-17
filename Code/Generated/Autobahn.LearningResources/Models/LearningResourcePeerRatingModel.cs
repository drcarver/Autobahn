//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePeerRatingModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The LearningResourcePeerRating Model
     /// </summary>
    public partial class LearningResourcePeerRatingModel : AutobahnBase, Interfaces.ILearningResourcePeerRating
    {
        /// <summary>
        /// Peer Rating Date
        /// <para>
        /// The date on which the Peer Rating was entered.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20171">Peer Rating Date</a>
        /// </para>
        /// </summary>
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// Learning Resource Adapted From URL
        /// <para>
        /// URL identifier of a learning resource for which this resource is an adaptation.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20367">Learning Resource Adapted From URL</a>
        /// </para>
        /// </summary>
        public Guid LearningResourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPeerRatingSystem"/> model
        /// </summary>
        public Guid PeerRatingSystemId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Learning Resource Peer Rating Value
        /// <para>
        /// An individual score, rating or level assigned to a Learning Resource by a person within the boundaries set by a Peer Rating System that may be aggregated to derive an overall score for the learning resource.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20161">Learning Resource Peer Rating Value</a>
        /// </para>
        /// </summary>
        public System.Decimal? Value { get; set; }

    }
}
