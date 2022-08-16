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
        /// 
        /// </summary>
        Guid? FullTimeEquivalency { get; set; }

        /// <summary>
        /// 
        /// </summary>
         HireDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PositionTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEmploymentSeparationReasonId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefEmploymentSeparationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         StandardOccupationalClassification { get; set; }

        /// <summary>
        /// 
        /// </summary>
         UnionMembershipName { get; set; }

        /// <summary>
        /// 
        /// </summary>
         WeeksEmployedPerYear { get; set; }

    }
}
