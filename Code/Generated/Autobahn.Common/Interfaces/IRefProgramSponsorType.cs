//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefProgramSponsorType.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefProgramSponsorType
     /// </summary>
    public partial interface IRefProgramSponsorType
    {
        /// <summary>
        /// Defines the RefProgramSponsorType.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefProgramSponsorType.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefProgramSponsorType.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Defines the RefProgramSponsorType.RefJurisdiction nullable property
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

        /// <summary>
        /// Defines the RefProgramSponsorType.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefProgramSponsorType.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefProgramSponsorType.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
