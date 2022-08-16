//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonAddressNcesSide.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonAddressNcesSide Interface
     /// </summary>
    public partial interface IPersonAddressNcesSide : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         NcesSideDateProcessed { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NcesSideEstimate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NcesSideStandardError { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NcesSideVintageBeginYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         NcesSideVintageEndYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

    }
}
