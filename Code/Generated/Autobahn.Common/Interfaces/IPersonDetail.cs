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
        /// 
        /// </summary>
        Guid? Birthdate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         BirthdateVerification { get; set; }

        /// <summary>
        /// 
        /// </summary>
         FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         GenerationCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HispanicLatinoEthnicity { get; set; }

        /// <summary>
        /// 
        /// </summary>
         LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         MiddleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Prefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefProofOfResidencyTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefSexId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefStateOfResidenceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTribalAffiliationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefUSCitizenshipStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefVisaTypeId { get; set; }

    }
}
