//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefDisciplineLengthDifferenceReason.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefDisciplineLengthDifferenceReason
     /// </summary>
    public partial interface IRefDisciplineLengthDifferenceReason
    {
        /// <summary>
        /// Defines the RefDisciplineLengthDifferenceReason.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefDisciplineLengthDifferenceReason.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefDisciplineLengthDifferenceReason.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefDisciplineLengthDifferenceReason.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefDisciplineLengthDifferenceReason.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefDisciplineLengthDifferenceReason.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
