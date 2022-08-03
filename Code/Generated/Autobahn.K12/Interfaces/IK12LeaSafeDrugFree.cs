//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaSafeDrugFree.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaSafeDrugFree
     /// </summary>
    public partial interface IK12LeaSafeDrugFree
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.Baseline non nullable property
        /// </summary>
        System.String Baseline { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.BaselineYear non nullable property
        /// </summary>
        System.String BaselineYear { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.CollectionFrequency non nullable property
        /// </summary>
        System.String CollectionFrequency { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.IndicatorName non nullable property
        /// </summary>
        System.String IndicatorName { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.Instrument non nullable property
        /// </summary>
        System.String Instrument { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.Performance non nullable property
        /// </summary>
        System.String Performance { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.Target non nullable property
        /// </summary>
        System.String Target { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.MostRecentCollection non nullable property
        /// </summary>
        System.String MostRecentCollection { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the K12LeaSafeDrugFree.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
