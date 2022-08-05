//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   IELChildOutcomeSummary.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELChildOutcomeSummary
     /// </summary>
    public partial interface IELChildOutcomeSummary : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the ELChildOutcomeSummary.COSProgressAIndicator nullable property
        /// </summary>
        System.Boolean? COSProgressAIndicator { get; set; }

        /// <summary>
        /// Defines the ELChildOutcomeSummary.COSProgressBIndicator nullable property
        /// </summary>
        System.Boolean? COSProgressBIndicator { get; set; }

        /// <summary>
        /// Defines the ELChildOutcomeSummary.COSProgressCIndicator nullable property
        /// </summary>
        System.Boolean? COSProgressCIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="COSRatingA"/> model
        /// </summary>
        Guid? COSRatingAId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="COSRatingB"/> model
        /// </summary>
        Guid? COSRatingBId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="COSRatingC"/> model
        /// </summary>
        Guid? COSRatingCId { get; set; }

    }
}
