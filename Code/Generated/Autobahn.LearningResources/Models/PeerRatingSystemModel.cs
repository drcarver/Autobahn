//**********************************************************
//* DomainName: Learning Resources
//* FileName:   PeerRatingSystemModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Interfaces
{
     /// <summary>
     /// The PeerRatingSystem Model
     /// </summary>
    public partial class PeerRatingSystemModel : AutobahnBase, Interfaces.IPeerRatingSystem
    {
        /// <summary>
        /// Peer Rating System Maximum Value
        /// <para>
        ///  The maximum value allowed by the Peer Rating System.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20162">Peer Rating System Maximum Value</a>
        /// </para>
        /// </summary>
        public System.Decimal? MaximumValue { get; set; }

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
        public System.Decimal? OptimumValue { get; set; }

    }
}
