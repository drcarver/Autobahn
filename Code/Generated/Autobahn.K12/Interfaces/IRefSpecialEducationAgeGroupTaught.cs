//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefSpecialEducationAgeGroupTaught.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefSpecialEducationAgeGroupTaught
     /// </summary>
    public partial interface IRefSpecialEducationAgeGroupTaught
    {
        /// <summary>
        /// Defines the RefSpecialEducationAgeGroupTaught.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationAgeGroupTaught.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationAgeGroupTaught.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationAgeGroupTaught.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationAgeGroupTaught.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefSpecialEducationAgeGroupTaught.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
