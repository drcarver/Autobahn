//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationTelephone.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationTelephone Interface
     /// </summary>
    public partial interface IOrganizationTelephone : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         DoNotPublishIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PrimaryTelephoneNumberIndicator { get; set; }

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
        Guid? RefInstitutionTelephoneTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefTelephoneNumberListedStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         TelephoneNumber { get; set; }

    }
}
