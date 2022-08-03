//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefStandardizedAdmissionTest.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IRefStandardizedAdmissionTest
     /// </summary>
    public partial interface IRefStandardizedAdmissionTest
    {
        /// <summary>
        /// Defines the RefStandardizedAdmissionTest.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefStandardizedAdmissionTest.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefStandardizedAdmissionTest.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefStandardizedAdmissionTest.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefStandardizedAdmissionTest.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefStandardizedAdmissionTest.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
