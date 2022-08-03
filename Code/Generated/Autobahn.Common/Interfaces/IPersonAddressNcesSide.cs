//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonAddressNcesSide.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonAddressNcesSide
     /// </summary>
    public partial interface IPersonAddressNcesSide
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonAddress"/> model
        /// </summary>
        Guid PersonAddressId { get; set; }

        /// <summary>
        /// Defines the PersonAddressNcesSide.NcesSideDateProcessed nullable property
        /// </summary>
        System.DateTime? NcesSideDateProcessed { get; set; }

        /// <summary>
        /// Defines the PersonAddressNcesSide.NcesSideEstimate nullable property
        /// </summary>
        System.Decimal? NcesSideEstimate { get; set; }

        /// <summary>
        /// Defines the PersonAddressNcesSide.NcesSideStandardError nullable property
        /// </summary>
        System.Decimal? NcesSideStandardError { get; set; }

        /// <summary>
        /// Defines the PersonAddressNcesSide.NcesSideVintageBeginYear non nullable property
        /// </summary>
        System.String NcesSideVintageBeginYear { get; set; }

        /// <summary>
        /// Defines the PersonAddressNcesSide.NcesSideVintageEndYear non nullable property
        /// </summary>
        System.String NcesSideVintageEndYear { get; set; }

        /// <summary>
        /// Defines the PersonAddressNcesSide.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonAddressNcesSide.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}