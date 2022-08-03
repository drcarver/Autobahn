//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   IRefIDEAInterimRemoval.cs
//**********************************************************

namespace Autobahn.Reference.Interfaces
{
     /// <summary>
     /// The IRefIDEAInterimRemoval
     /// </summary>
    public partial interface IRefIDEAInterimRemoval
    {
        /// <summary>
        /// Defines the RefIDEAInterimRemoval.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefIDEAInterimRemoval.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefIDEAInterimRemoval.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefIDEAInterimRemoval.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefIDEAInterimRemoval.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefIDEAInterimRemoval.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
