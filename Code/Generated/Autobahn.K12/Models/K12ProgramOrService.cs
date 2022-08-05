//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12ProgramOrService.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12ProgramOrService
     /// </summary>
    public partial class K12ProgramOrService : AutobahnBase, Interfaces.IK12ProgramOrService
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the K12ProgramOrService.ProgramInMultiplePurposeFacility nullable property
        /// </summary>
        public System.Boolean? ProgramInMultiplePurposeFacility { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrekindergartenDailyLength"/> model
        /// </summary>
        public Guid? RefPrekindergartenDailyLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKindergartenDailyLength"/> model
        /// </summary>
        public Guid? RefKindergartenDailyLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramGiftedEligibility"/> model
        /// </summary>
        public Guid? RefProgramGiftedEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepSessionType"/> model
        /// </summary>
        public Guid? RefMepSessionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectType"/> model
        /// </summary>
        public Guid? RefMepProjectTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIInstructionalServices"/> model
        /// </summary>
        public Guid? RefTitleIInstructionalServicesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIProgramType"/> model
        /// </summary>
        public Guid? RefTitleIProgramTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
