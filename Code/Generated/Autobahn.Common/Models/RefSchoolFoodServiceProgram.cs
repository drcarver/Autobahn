//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSchoolFoodServiceProgram.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The RefSchoolFoodServiceProgram
     /// </summary>
    public partial class RefSchoolFoodServiceProgram : IRefSchoolFoodServiceProgram
    {
        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.RefJurisdiction nullable property
        /// </summary>
        public System.Int32? RefJurisdiction { get; set; }

        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
