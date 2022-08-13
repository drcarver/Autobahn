//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12LeaSafeDrugFree.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaSafeDrugFree Interface
     /// </summary>
    public partial interface IK12LeaSafeDrugFree : IAutobahnBase
    {
        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        System.String Baseline { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        System.String BaselineYear { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        System.String CollectionFrequency { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        System.String IndicatorName { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        System.String Instrument { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        System.String MostRecentCollection { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        System.String Performance { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        System.String Target { get; set; }

    }
}
