//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDetail.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDetail Interface
     /// </summary>
    public partial interface IPersonDetail : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        System.DateTime? Birthdate { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        System.String BirthdateVerification { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        System.String FirstName { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        System.String GenerationCode { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        System.Boolean? HispanicLatinoEthnicity { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        System.String LastName { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        System.String MiddleName { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        System.String Prefix { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        Guid? RefProofOfResidencyTypeId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        Guid? RefSexId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        Guid? RefStateOfResidenceId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        Guid? RefTribalAffiliationId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        Guid? RefUSCitizenshipStatusId { get; set; }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        Guid? RefVisaTypeId { get; set; }

    }
}
