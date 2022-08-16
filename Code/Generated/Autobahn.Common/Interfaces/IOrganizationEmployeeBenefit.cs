//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationEmployeeBenefit.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationEmployeeBenefit Interface
     /// </summary>
    public partial interface IOrganizationEmployeeBenefit : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? FullTimeBenefitIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
         PartTimeBenefitIndicator { get; set; }

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
         RefEmployeeBenefitId { get; set; }

    }
}
