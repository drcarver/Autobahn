//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressNcesSideModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAddressNcesSide Model
     /// </summary>
    public partial class PersonAddressNcesSideModel : AutobahnBase, Interfaces.IPersonAddressNcesSide
    {
        /// <summary>
        /// 
        /// </summary>
        public  NcesSideDateProcessed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NcesSideEstimate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NcesSideStandardError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NcesSideVintageBeginYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NcesSideVintageEndYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
