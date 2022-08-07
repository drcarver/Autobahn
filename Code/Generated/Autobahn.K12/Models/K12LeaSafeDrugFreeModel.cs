//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaSafeDrugFreeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12LeaSafeDrugFree Model
     /// </summary>
    public partial class K12LeaSafeDrugFreeModel : AutobahnBase, Interfaces.IK12LeaSafeDrugFreeModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.Baseline non nullable property
        /// </summary>
        public System.String Baseline { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.BaselineYear non nullable property
        /// </summary>
        public System.String BaselineYear { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.CollectionFrequency non nullable property
        /// </summary>
        public System.String CollectionFrequency { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.IndicatorName non nullable property
        /// </summary>
        public System.String IndicatorName { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.Instrument non nullable property
        /// </summary>
        public System.String Instrument { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.Performance non nullable property
        /// </summary>
        public System.String Performance { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.Target non nullable property
        /// </summary>
        public System.String Target { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.MostRecentCollection non nullable property
        /// </summary>
        public System.String MostRecentCollection { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
