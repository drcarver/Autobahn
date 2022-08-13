//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDetailModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDetail Model
     /// </summary>
    public partial class PersonDetailModel : AutobahnBase, Interfaces.IPersonDetail
    {
        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.DateTime? Birthdate { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.String BirthdateVerification { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.String FirstName { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.String GenerationCode { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.Boolean? HispanicLatinoEthnicity { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.String LastName { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.String MiddleName { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.String Prefix { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public Guid? RefProofOfResidencyTypeId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public Guid? RefSexId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public Guid? RefStateOfResidenceId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public Guid? RefTribalAffiliationId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public Guid? RefUSCitizenshipStatusId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public Guid? RefVisaTypeId { get; set; }

    }
}
