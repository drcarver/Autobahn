//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12StaffEmployment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12StaffEmployment Interface
     /// </summary>
    public partial interface IK12StaffEmployment : IAutobahnBase
    {
        /// <summary>
        /// The number of days per year that a person is expected to work as outlined specifically in his or her employment agreement.
        /// </summary>
        System.Decimal? ContractDaysOfServicePerYear { get; set; }

    }
}
