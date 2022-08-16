//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonLanguage.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonLanguage Interface
     /// </summary>
    public partial interface IPersonLanguage : IAutobahnBase
    {
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
         RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefLanguageUseTypeId { get; set; }

    }
}
