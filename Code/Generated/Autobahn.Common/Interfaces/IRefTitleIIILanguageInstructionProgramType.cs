//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefTitleIIILanguageInstructionProgramType.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefTitleIIILanguageInstructionProgramType
     /// </summary>
    public partial interface IRefTitleIIILanguageInstructionProgramType
    {
        /// <summary>
        /// Defines the RefTitleIIILanguageInstructionProgramType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefTitleIIILanguageInstructionProgramType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefTitleIIILanguageInstructionProgramType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefTitleIIILanguageInstructionProgramType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefTitleIIILanguageInstructionProgramType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefTitleIIILanguageInstructionProgramType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
