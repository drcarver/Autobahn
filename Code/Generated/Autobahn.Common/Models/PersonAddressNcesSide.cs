//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonAddressNcesSide.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAddressNcesSide
     /// </summary>
    public partial class PersonAddressNcesSide : AutobahnBase, Interfaces.IPersonAddressNcesSide
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonAddress"/> model
        /// </summary>
        public Guid PersonAddressId { get; set; }

        /// <summary>
        /// Defines the PersonAddressNcesSide.NcesSideDateProcessed nullable property
        /// </summary>
        public System.DateTime? NcesSideDateProcessed { get; set; }

        /// <summary>
        /// Defines the PersonAddressNcesSide.NcesSideEstimate nullable property
        /// </summary>
        public System.Decimal? NcesSideEstimate { get; set; }

        /// <summary>
        /// Defines the PersonAddressNcesSide.NcesSideStandardError nullable property
        /// </summary>
        public System.Decimal? NcesSideStandardError { get; set; }

        /// <summary>
        /// Defines the PersonAddressNcesSide.NcesSideVintageBeginYear non nullable property
        /// </summary>
        public System.String NcesSideVintageBeginYear { get; set; }

        /// <summary>
        /// Defines the PersonAddressNcesSide.NcesSideVintageEndYear non nullable property
        /// </summary>
        public System.String NcesSideVintageEndYear { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
