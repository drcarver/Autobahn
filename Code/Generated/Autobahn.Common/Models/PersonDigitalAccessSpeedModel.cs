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
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? InternetDownloadSpeed { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.DateTime? InternetSpeedTestDateTime { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? InternetUploadSpeed { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? PersonDigitalAccessId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? PersonLearningDeviceId { get; set; }

    }
}
