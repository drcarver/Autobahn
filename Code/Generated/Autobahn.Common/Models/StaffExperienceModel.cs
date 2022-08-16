//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffExperienceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffExperience Model
     /// </summary>
    public partial class StaffExperienceModel : AutobahnBase, Interfaces.IStaffExperience
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  YearsOfPriorAETeachingExperience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? YearsOfPriorTeachingExperience { get; set; }

    }
}
