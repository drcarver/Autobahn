//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffEmployment.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffEmployment Interface
     /// </summary>
    public partial interface IStaffEmployment : IAutobahnBase
    {
        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        System.Decimal? FullTimeEquivalency { get; set; }

    }
}
