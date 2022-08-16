//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessSpeedModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDigitalAccessSpeed Model
     /// </summary>
    public partial class PersonDigitalAccessSpeedModel : AutobahnBase, Interfaces.IPersonDigitalAccessSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        public  InternetDownloadSpeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InternetSpeedTestDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  InternetUploadSpeed { get; set; }

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
