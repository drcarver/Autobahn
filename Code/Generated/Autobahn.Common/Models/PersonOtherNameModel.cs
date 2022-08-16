//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonOtherNameModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonOtherName Model
     /// </summary>
    public partial class PersonOtherNameModel : AutobahnBase, Interfaces.IPersonOtherName
    {
        /// <summary>
        /// 
        /// </summary>
        public  FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  MiddleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? OtherName { get; set; }

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
        public  RefOtherNameTypeId { get; set; }

    }
}
