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
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public System.Boolean? InternetAccessInResidence { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? PersonAddressId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefBarrierToInternetAccessInResidenceId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefInternetAccessTypeInResidenceId { get; set; }

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? RefInternetPerformanceInResidenceId { get; set; }

    }
}
