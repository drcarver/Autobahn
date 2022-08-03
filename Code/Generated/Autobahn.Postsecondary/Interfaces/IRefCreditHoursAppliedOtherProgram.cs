//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefCreditHoursAppliedOtherProgram.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IRefCreditHoursAppliedOtherProgram
     /// </summary>
    public partial interface IRefCreditHoursAppliedOtherProgram
    {
        /// <summary>
        /// Defines the RefCreditHoursAppliedOtherProgram.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefCreditHoursAppliedOtherProgram.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefCreditHoursAppliedOtherProgram.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefCreditHoursAppliedOtherProgram.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefCreditHoursAppliedOtherProgram.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefCreditHoursAppliedOtherProgram.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
