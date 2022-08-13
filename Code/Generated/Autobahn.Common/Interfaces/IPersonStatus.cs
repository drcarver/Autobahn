//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonStatus.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonStatus Interface
     /// </summary>
    public partial interface IPersonStatus : IAutobahnBase
    {
        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        Guid RefPersonStatusTypeId { get; set; }

        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        System.DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        System.DateTime? StatusStartDate { get; set; }

        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        System.Boolean StatusValue { get; set; }

    }
}
