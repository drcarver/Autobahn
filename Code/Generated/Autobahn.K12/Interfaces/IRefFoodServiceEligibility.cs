//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefFoodServiceEligibility.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefFoodServiceEligibility
     /// </summary>
    public partial interface IRefFoodServiceEligibility
    {
        /// <summary>
        /// Defines the RefFoodServiceEligibility.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFoodServiceEligibility.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFoodServiceEligibility.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Defines the RefFoodServiceEligibility.RefJurisdiction nullable property
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

        /// <summary>
        /// Defines the RefFoodServiceEligibility.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFoodServiceEligibility.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFoodServiceEligibility.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
