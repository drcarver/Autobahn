//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IGoal.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IGoal
     /// </summary>
    public partial interface IGoal : IAutobahnBase
    {
        /// <summary>
        /// Defines the Goal.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the Goal.StartDate nullable property
        /// </summary>
        System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Defines the Goal.EndDate nullable property
        /// </summary>
        System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        Guid? OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="CompetencySet"/> model
        /// </summary>
        Guid? CompetencySetId { get; set; }

    }
}
