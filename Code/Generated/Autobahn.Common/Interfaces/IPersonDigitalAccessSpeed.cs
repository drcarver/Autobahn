//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDigitalAccessSpeed.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDigitalAccessSpeed Interface
     /// </summary>
    public partial interface IPersonDigitalAccessSpeed : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         InternetDownloadSpeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InternetSpeedTestDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         InternetUploadSpeed { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

    }
}
