//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefPsEnrollmentAction.cs
//**********************************************************

using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefPsEnrollmentAction
     /// </summary>
    public partial class RefPsEnrollmentAction : IRefPsEnrollmentAction
    {
        /// <summary>
        /// Defines the RefPsEnrollmentAction.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefPsEnrollmentAction.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefPsEnrollmentAction.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Defines the RefPsEnrollmentAction.RefJurisdiction nullable property
        /// </summary>
        public System.Int32? RefJurisdiction { get; set; }

        /// <summary>
        /// Defines the RefPsEnrollmentAction.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefPsEnrollmentAction.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefPsEnrollmentAction.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
