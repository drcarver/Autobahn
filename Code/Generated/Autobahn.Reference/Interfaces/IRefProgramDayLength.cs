//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   IRefProgramDayLength.cs
//**********************************************************

namespace Autobahn.Reference.Interfaces
{
     /// <summary>
     /// The IRefProgramDayLength
     /// </summary>
    public partial interface IRefProgramDayLength
    {
        /// <summary>
        /// Defines the RefProgramDayLength.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefProgramDayLength.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefProgramDayLength.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefProgramDayLength.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefProgramDayLength.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefProgramDayLength.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
