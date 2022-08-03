//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   IRefAdmissionConsiderationLevel.cs
//**********************************************************

namespace Autobahn.Postsecondary.Interfaces
{
     /// <summary>
     /// The IRefAdmissionConsiderationLevel
     /// </summary>
    public partial interface IRefAdmissionConsiderationLevel
    {
        /// <summary>
        /// Defines the RefAdmissionConsiderationLevel.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefAdmissionConsiderationLevel.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefAdmissionConsiderationLevel.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefAdmissionConsiderationLevel.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefAdmissionConsiderationLevel.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefAdmissionConsiderationLevel.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
