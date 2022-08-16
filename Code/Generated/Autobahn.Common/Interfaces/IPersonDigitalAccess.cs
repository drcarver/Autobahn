//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDigitalAccess.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDigitalAccess Interface
     /// </summary>
    public partial interface IPersonDigitalAccess : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         InternetAccessInResidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefBarrierToInternetAccessInResidenceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefInternetAccessTypeInResidenceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefInternetPerformanceInResidenceId { get; set; }

    }
}
