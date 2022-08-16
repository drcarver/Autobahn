//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDigitalAccess Model
     /// </summary>
    public partial class PersonDigitalAccessModel : AutobahnBase, Interfaces.IPersonDigitalAccess
    {
        /// <summary>
        /// 
        /// </summary>
        public  InternetAccessInResidence { get; set; }

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
        public  RefBarrierToInternetAccessInResidenceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefInternetAccessTypeInResidenceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefInternetPerformanceInResidenceId { get; set; }

    }
}
