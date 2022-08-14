//***************************************************************************
//* DomainName: Assessments Interfaces (used by both models and View Models
//* FileName:   IGoal.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessments.Interfaces
{
     /// <summary>
     /// The IGoal Interface
     /// </summary>
    public partial interface IGoal : IAutobahnBase
    {
        /// <summary>
        /// A statement that describes the desired outcomes.
        /// </summary>
        Guid? CompetencySetId { get; set; }

        /// <summary>
        /// A statement that describes the desired outcomes.
        /// </summary>
        System.DateTime? EndDate { get; set; }

        /// <summary>
        /// A statement that describes the desired outcomes.
        /// </summary>
        Guid? OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// A statement that describes the desired outcomes.
        /// </summary>
        System.DateTime? StartDate { get; set; }

    }
}
