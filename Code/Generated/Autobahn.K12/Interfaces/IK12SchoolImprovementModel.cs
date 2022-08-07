//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12SchoolImprovementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolImprovementModel Interface
     /// </summary>
    public partial interface IK12SchoolImprovementModel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12School"/> model
        /// </summary>
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementStatus"/> model
        /// </summary>
        Guid? RefSchoolImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSchoolImprovementFunds"/> model
        /// </summary>
        Guid? RefSchoolImprovementFundsId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSigInterventionType"/> model
        /// </summary>
        Guid? RefSigInterventionTypeId { get; set; }

        /// <summary>
        /// Defines the K12SchoolImprovement.SchoolImprovementExitDate nullable property
        /// </summary>
        System.DateTime? SchoolImprovementExitDate { get; set; }

    }
}
