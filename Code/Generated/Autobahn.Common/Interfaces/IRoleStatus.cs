//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IRoleStatus.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRoleStatus Interface
     /// </summary>
    public partial interface IRoleStatus : IAutobahnBase
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
        Guid? RefRoleStatusId { get; set; }

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
