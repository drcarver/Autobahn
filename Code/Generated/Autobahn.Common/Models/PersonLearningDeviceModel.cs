//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLearningDeviceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonLearningDevice Model
     /// </summary>
    public partial class PersonLearningDeviceModel : AutobahnBase, Interfaces.IPersonLearningDevice
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPrimaryLearningDeviceAccessId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPrimaryLearningDeviceAwayFromSchoolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPrimaryLearningDeviceProviderId { get; set; }

    }
}
