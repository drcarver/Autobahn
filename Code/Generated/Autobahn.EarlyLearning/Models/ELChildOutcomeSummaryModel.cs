//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildOutcomeSummaryModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildOutcomeSummary Model
     /// </summary>
    public partial class ELChildOutcomeSummaryModel : AutobahnBase, Interfaces.IELChildOutcomeSummary
    {
        /// <summary>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </summary>
        public System.Boolean? COSProgressAIndicator { get; set; }

        /// <summary>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </summary>
        public System.Boolean? COSProgressBIndicator { get; set; }

        /// <summary>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </summary>
        public System.Boolean? COSProgressCIndicator { get; set; }

        /// <summary>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </summary>
        public Guid? COSRatingAId { get; set; }

        /// <summary>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </summary>
        public Guid? COSRatingBId { get; set; }

        /// <summary>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </summary>
        public Guid? COSRatingCId { get; set; }

        /// <summary>
        /// Indicates that the child demonstrates progress in positive social-emotional skills, including social relationships.
        /// </summary>
        public Guid PersonId { get; set; }

    }
}