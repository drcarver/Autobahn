//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12ProgramOrServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12ProgramOrService Model
     /// </summary>
    public partial class K12ProgramOrServiceModel : AutobahnBase, Interfaces.IK12ProgramOrService
    {
        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        public System.Boolean? ProgramInMultiplePurposeFacility { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        public Guid? RefKindergartenDailyLengthId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        public Guid? RefMepProjectTypeId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        public Guid? RefMepSessionTypeId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        public Guid? RefPrekindergartenDailyLengthId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        public Guid? RefProgramGiftedEligibilityId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        public Guid? RefTitleIInstructionalServicesId { get; set; }

        /// <summary>
        /// The time of year that a Migrant Education Program operates.
        /// </summary>
        public Guid? RefTitleIProgramTypeId { get; set; }

    }
}
