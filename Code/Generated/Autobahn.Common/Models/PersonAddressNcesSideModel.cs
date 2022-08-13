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
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.DateTime? NcesSideDateProcessed { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? NcesSideEstimate { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Decimal? NcesSideStandardError { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String NcesSideVintageBeginYear { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.String NcesSideVintageEndYear { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid PersonAddressId { get; set; }

    }
}
