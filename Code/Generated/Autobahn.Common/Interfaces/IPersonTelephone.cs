//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonTelephone.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonTelephone Interface
     /// </summary>
    public partial interface IPersonTelephone : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         DoNotPublishIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? PrimaryTelephoneNumberIndicator { get; set; }

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
         RefPersonTelephoneNumberTypeId { get; set; }

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
