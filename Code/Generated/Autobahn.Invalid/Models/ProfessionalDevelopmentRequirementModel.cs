//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProfessionalDevelopmentRequirementModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProfessionalDevelopmentRequirement Model
     /// </summary>
    public partial class ProfessionalDevelopmentRequirementModel : AutobahnBase, Interfaces.IProfessionalDevelopmentRequirement
    {
        /// <summary>
        /// Number of clock hours of training required for providers to meet requirements of the state.
        /// </summary>
        public Guid? CompetencySetId { get; set; }

        /// <summary>
        /// Number of clock hours of training required for providers to meet requirements of the state.
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Number of clock hours of training required for providers to meet requirements of the state.
        /// </summary>
        public System.Decimal? RequiredTrainingClockHours { get; set; }

    }
}
