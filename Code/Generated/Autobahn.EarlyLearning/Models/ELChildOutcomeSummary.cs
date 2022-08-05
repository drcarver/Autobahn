//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELChildOutcomeSummary.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildOutcomeSummary
     /// </summary>
    public partial class ELChildOutcomeSummary : AutobahnBase, Interfaces.IELChildOutcomeSummary
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the ELChildOutcomeSummary.COSProgressAIndicator nullable property
        /// </summary>
        public System.Boolean? COSProgressAIndicator { get; set; }

        /// <summary>
        /// Defines the ELChildOutcomeSummary.COSProgressBIndicator nullable property
        /// </summary>
        public System.Boolean? COSProgressBIndicator { get; set; }

        /// <summary>
        /// Defines the ELChildOutcomeSummary.COSProgressCIndicator nullable property
        /// </summary>
        public System.Boolean? COSProgressCIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="COSRatingA"/> model
        /// </summary>
        public Guid? COSRatingAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="COSRatingB"/> model
        /// </summary>
        public Guid? COSRatingBId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="COSRatingC"/> model
        /// </summary>
        public Guid? COSRatingCId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
