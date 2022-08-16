//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonEmailAddress.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonEmailAddress Interface
     /// </summary>
    public partial interface IPersonEmailAddress : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         DoNotPublishIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? EmailAddress { get; set; }

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
         RefEmailTypeId { get; set; }

    }
}
