//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffExperience.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffExperience Interface
     /// </summary>
    public partial interface IStaffExperience : IAutobahnBase
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
         YearsOfPriorAETeachingExperience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? YearsOfPriorTeachingExperience { get; set; }

    }
}
