//**********************************************************
//* DomainName: Autobahn.Workforce
//* FileName:   IRefWfProgramParticipation.cs
//**********************************************************

namespace Autobahn.Workforce.Interfaces
{
     /// <summary>
     /// The IRefWfProgramParticipation
     /// </summary>
    public partial interface IRefWfProgramParticipation
    {
        /// <summary>
        /// Defines the RefWfProgramParticipation.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefWfProgramParticipation.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefWfProgramParticipation.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefWfProgramParticipation.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefWfProgramParticipation.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefWfProgramParticipation.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
