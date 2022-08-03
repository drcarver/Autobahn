//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefStandardizedAdmissionTest.cs
//**********************************************************

using Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The RefStandardizedAdmissionTest
     /// </summary>
    public partial class RefStandardizedAdmissionTest : IRefStandardizedAdmissionTest
    {
        /// <summary>
        /// Defines the RefStandardizedAdmissionTest.Description non nullable property
        /// </summary>
        public System.String Description { get; set; }

        /// <summary>
        /// Defines the RefStandardizedAdmissionTest.Code non nullable property
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// Defines the RefStandardizedAdmissionTest.Definition non nullable property
        /// </summary>
        public System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        public Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefStandardizedAdmissionTest.SortOrder nullable property
        /// </summary>
        public System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefStandardizedAdmissionTest.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefStandardizedAdmissionTest.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

    }
}
