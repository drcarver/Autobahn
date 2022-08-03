//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonDetail.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDetail
     /// </summary>
    public partial interface IPersonDetail
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonDetail.FirstName non nullable property
        /// </summary>
        System.String FirstName { get; set; }

        /// <summary>
        /// Defines the PersonDetail.MiddleName non nullable property
        /// </summary>
        System.String MiddleName { get; set; }

        /// <summary>
        /// Defines the PersonDetail.LastName non nullable property
        /// </summary>
        System.String LastName { get; set; }

        /// <summary>
        /// Defines the PersonDetail.GenerationCode non nullable property
        /// </summary>
        System.String GenerationCode { get; set; }

        /// <summary>
        /// Defines the PersonDetail.Prefix non nullable property
        /// </summary>
        System.String Prefix { get; set; }

        /// <summary>
        /// Defines the PersonDetail.Birthdate nullable property
        /// </summary>
        System.DateTime? Birthdate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSex"/> model
        /// </summary>
        Guid? RefSexId { get; set; }

        /// <summary>
        /// Defines the PersonDetail.HispanicLatinoEthnicity nullable property
        /// </summary>
        System.Boolean? HispanicLatinoEthnicity { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefUSCitizenshipStatus"/> model
        /// </summary>
        Guid? RefUSCitizenshipStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisaType"/> model
        /// </summary>
        Guid? RefVisaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateOfResidence"/> model
        /// </summary>
        Guid? RefStateOfResidenceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProofOfResidencyType"/> model
        /// </summary>
        Guid? RefProofOfResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighestEducationLevelCompleted"/> model
        /// </summary>
        Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// Defines the PersonDetail.BirthdateVerification non nullable property
        /// </summary>
        System.String BirthdateVerification { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTribalAffiliation"/> model
        /// </summary>
        Guid? RefTribalAffiliationId { get; set; }

        /// <summary>
        /// Defines the PersonDetail.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonDetail.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
