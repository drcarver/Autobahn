//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonStatusModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonStatus Model
     /// </summary>
    public partial class PersonStatusModel : AutobahnBase, Interfaces.IPersonStatus
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
        public Guid? RefPersonStatusTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StatusEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StatusStartDate { get; set; }

    }
}
