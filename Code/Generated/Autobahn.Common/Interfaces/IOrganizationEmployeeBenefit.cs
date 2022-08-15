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
        /// The benefits offered by a program/facility/employer for full-time staff.
        /// </summary>
        System.Boolean? FullTimeBenefitIndicator { get; set; }

    }
}
