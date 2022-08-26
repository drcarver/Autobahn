//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12programOrServiceModel.cs
//***************************************************************************

using Autobahn.Interfaces.K12;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12programOrService Model
     /// </summary>
    public partial class K12programOrServiceModel : AutobahnBase, IK12programOrService
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        public Boolean? ProgramInMultiplePurposeFacility { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKindergartenDailyLength"/> model
        /// </summary>
        public Guid? RefKindergartenDailyLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectType"/> model
        /// </summary>
        public Guid? RefMepProjectTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepSessionType"/> model
        /// </summary>
        public Guid? RefMepSessionTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrekindergartenDailyLength"/> model
        /// </summary>
        public Guid? RefPrekindergartenDailyLengthId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramGiftedEligibility"/> model
        /// </summary>
        public Guid? RefProgramGiftedEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIinstructionalServices"/> model
        /// </summary>
        public Guid? RefTitleIinstructionalServicesId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIprogramType"/> model
        /// </summary>
        public Guid? RefTitleIprogramTypeId { get; set; }

    }
}
