//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaSafeDrugFreeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaSafeDrugFree Model
     /// </summary>
    public partial class K12LeaSafeDrugFreeModel : AutobahnBase, Interfaces.IK12LeaSafeDrugFree
    {
        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String Baseline { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String BaselineYear { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String CollectionFrequency { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String IndicatorName { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String Instrument { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String MostRecentCollection { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String Performance { get; set; }

        /// <summary>
        /// The name of the performance indicator for student behaviors under the Safe and Drug-Free Schools and Communities Act.
        /// </summary>
        public System.String Target { get; set; }

    }
}
