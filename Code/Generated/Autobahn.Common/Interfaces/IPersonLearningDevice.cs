//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonLearningDevice.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonLearningDevice Interface
     /// </summary>
    public partial interface IPersonLearningDevice : IAutobahnBase
    {
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
         RefPrimaryLearningDeviceAccessId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPrimaryLearningDeviceAwayFromSchoolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefPrimaryLearningDeviceProviderId { get; set; }

    }
}
