using System;

namespace Autobahn.Entities
{
    public partial class K12ProgramOrService
    {
        public int K12ProgramOrServiceId { get; set; }

        public int OrganizationId { get; set; }

        public bool? ProgramInMultiplePurposeFacility { get; set; }

        public int? RefPrekindergartenDailyLengthId { get; set; }

        public int? RefKindergartenDailyLengthId { get; set; }

        public int? RefProgramGiftedEligibilityId { get; set; }

        public int? RefMepSessionTypeId { get; set; }

        public int? RefMepProjectTypeId { get; set; }

        public int? RefTitleIInstructionalServicesId { get; set; }

        public int? RefTitleIProgramTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RefMepProjectType RefMepProjectType { get; set; }

        public virtual RefMepSessionType RefMepSessionType { get; set; }

        public virtual RefProgramDayLength RefProgramDayLength { get; set; }

        public virtual RefProgramDayLength RefProgramDayLength1 { get; set; }

        public virtual RefProgramGiftedEligibility RefProgramGiftedEligibility { get; set; }

        public virtual RefTitleIInstructionalService RefTitleIInstructionalService { get; set; }

        public virtual RefTitleIProgramType RefTitleIProgramType { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
