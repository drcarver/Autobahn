//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonAddressNcesSideModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonAddressNcesSideModel Interface
     /// </summary>
    public partial interface IPersonAddressNcesSideModel : IAutobahnBase
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

    }
}
