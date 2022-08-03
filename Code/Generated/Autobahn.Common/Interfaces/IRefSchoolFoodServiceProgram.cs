//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefSchoolFoodServiceProgram.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefSchoolFoodServiceProgram
     /// </summary>
    public partial interface IRefSchoolFoodServiceProgram
    {
        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.RefJurisdiction nullable property
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefSchoolFoodServiceProgram.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
