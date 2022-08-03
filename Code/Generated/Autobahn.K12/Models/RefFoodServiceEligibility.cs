//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefFoodServiceEligibility.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefFoodServiceEligibility
     /// </summary>
    public partial class RefFoodServiceEligibility : IRefFoodServiceEligibility
    {
        /// <summary>
        /// Defines the RefFoodServiceEligibility.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefFoodServiceEligibility.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefFoodServiceEligibility.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Defines the RefFoodServiceEligibility.RefJurisdiction nullable property
        /// </summary>
        public System.Int32? RefJurisdiction { get; set; }

        /// <summary>
        /// Defines the RefFoodServiceEligibility.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefFoodServiceEligibility.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefFoodServiceEligibility.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
