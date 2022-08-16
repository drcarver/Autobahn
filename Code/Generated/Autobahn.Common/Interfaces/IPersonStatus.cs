//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonStatus.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonStatus Interface
     /// </summary>
    public partial interface IPersonStatus : IAutobahnBase
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
        Guid? RefPersonStatusTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StatusEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StatusStartDate { get; set; }

    }
}
