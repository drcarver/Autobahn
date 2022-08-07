//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDetailModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDetail Model
     /// </summary>
    public partial class PersonDetailModel : AutobahnBase, Interfaces.IPersonDetailModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Defines the PersonDetail.FirstName non nullable property
        /// </summary>
        public System.String FirstName { get; set; }

        /// <summary>
        /// Defines the PersonDetail.MiddleName non nullable property
        /// </summary>
        public System.String MiddleName { get; set; }

        /// <summary>
        /// Defines the PersonDetail.LastName non nullable property
        /// </summary>
        public System.String LastName { get; set; }

        /// <summary>
        /// Defines the PersonDetail.GenerationCode non nullable property
        /// </summary>
        public System.String GenerationCode { get; set; }

        /// <summary>
        /// Defines the PersonDetail.Prefix non nullable property
        /// </summary>
        public System.String Prefix { get; set; }

        /// <summary>
        /// Defines the PersonDetail.Birthdate nullable property
        /// </summary>
        public System.DateTime? Birthdate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSex"/> model
        /// </summary>
        public Guid? RefSexId { get; set; }

        /// <summary>
        /// Defines the PersonDetail.HispanicLatinoEthnicity nullable property
        /// </summary>
        public System.Boolean? HispanicLatinoEthnicity { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefUSCitizenshipStatus"/> model
        /// </summary>
        public Guid? RefUSCitizenshipStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisaType"/> model
        /// </summary>
        public Guid? RefVisaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateOfResidence"/> model
        /// </summary>
        public Guid? RefStateOfResidenceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProofOfResidencyType"/> model
        /// </summary>
        public Guid? RefProofOfResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighestEducationLevelCompleted"/> model
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// Defines the PersonDetail.BirthdateVerification non nullable property
        /// </summary>
        public System.String BirthdateVerification { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTribalAffiliation"/> model
        /// </summary>
        public Guid? RefTribalAffiliationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
