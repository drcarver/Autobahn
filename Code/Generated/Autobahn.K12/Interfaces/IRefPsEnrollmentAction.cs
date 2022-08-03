//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefPsEnrollmentAction.cs
//**********************************************************

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IRefPsEnrollmentAction
     /// </summary>
    public partial interface IRefPsEnrollmentAction
    {
        /// <summary>
        /// Defines the RefPsEnrollmentAction.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPsEnrollmentAction.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPsEnrollmentAction.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Defines the RefPsEnrollmentAction.RefJurisdiction nullable property
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

        /// <summary>
        /// Defines the RefPsEnrollmentAction.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPsEnrollmentAction.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPsEnrollmentAction.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
