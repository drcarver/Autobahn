//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonStatusModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonStatusModel Interface
     /// </summary>
    public partial interface IPersonStatusModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPersonStatusType"/> model
        /// </summary>
        Guid RefPersonStatusTypeId { get; set; }

        /// <summary>
        /// Defines the PersonStatus.StatusValue non nullable property
        /// </summary>
        System.Boolean StatusValue { get; set; }

        /// <summary>
        /// Defines the PersonStatus.StatusStartDate nullable property
        /// </summary>
        System.DateTime? StatusStartDate { get; set; }

        /// <summary>
        /// Defines the PersonStatus.StatusEndDate nullable property
        /// </summary>
        System.DateTime? StatusEndDate { get; set; }

    }
}
