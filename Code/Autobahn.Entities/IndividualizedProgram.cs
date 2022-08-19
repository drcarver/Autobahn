using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("IndividualizedProgram")]
    public partial class IndividualizedProgram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IndividualizedProgram()
        {
            ELChildIndividualizedPrograms = new HashSet<ELChildIndividualizedProgram>();
            ELChildTransitionPlans = new HashSet<ELChildTransitionPlan>();
            IEPAuthorizations = new HashSet<IEPAuthorization>();
            IEPPresentLevels = new HashSet<IEPPresentLevel>();
            IndividualizedProgramAccommodations = new HashSet<IndividualizedProgramAccommodation>();
            IndividualizedProgramAmendments = new HashSet<IndividualizedProgramAmendment>();
            IndividualizedProgramAssessments = new HashSet<IndividualizedProgramAssessment>();
            IndividualizedProgramEligibilities = new HashSet<IndividualizedProgramEligibility>();
            IndividualizedProgramGoals = new HashSet<IndividualizedProgramGoal>();
            IndividualizedProgramMeetings = new HashSet<IndividualizedProgramMeeting>();
            IndividualizedProgramProgressReports = new HashSet<IndividualizedProgramProgressReport>();
            IndividualizedProgramProgressReportPlans = new HashSet<IndividualizedProgramProgressReportPlan>();
            IndividualizedProgramServicesReceiveds = new HashSet<IndividualizedProgramServicesReceived>();
        }

        public int IndividualizedProgramId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public int? RefIndividualizedProgramDateType { get; set; }

        [Column(TypeName = "date")]
        public DateTime? IndividualizedProgramDate { get; set; }

        public int? NonInclusionMinutesPerWeek { get; set; }

        public int? InclusionMinutesPerWeek { get; set; }

        public int? RefIndividualizedProgramTransitionTypeId { get; set; }

        public int? RefIndividualizedProgramTypeId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ServicePlanDate { get; set; }

        public int? RefIndividualizedProgramLocationId { get; set; }

        [StringLength(4000)]
        public string ServicePlanMeetingParticipants { get; set; }

        [StringLength(4000)]
        public string ServicePlanSignedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ServicePlanSignatureDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ServicePlanReevaluationDate { get; set; }

        public int? RefStudentSupportServiceTypeId { get; set; }

        public bool? InclusiveSettingIndicator { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ServicePlanEndDate { get; set; }

        public string TransferOfRightsStatement { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELChildIndividualizedProgram> ELChildIndividualizedPrograms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELChildTransitionPlan> ELChildTransitionPlans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IEPAuthorization> IEPAuthorizations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IEPPresentLevel> IEPPresentLevels { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefIndividualizedProgramType RefIndividualizedProgramType { get; set; }

        public virtual RefIndividualizedProgramDateType RefIndividualizedProgramDateType1 { get; set; }

        public virtual RefIndividualizedProgramLocation RefIndividualizedProgramLocation { get; set; }

        public virtual RefIndividualizedProgramTransitionType RefIndividualizedProgramTransitionType { get; set; }

        public virtual RefStudentSupportServiceType RefStudentSupportServiceType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramAccommodation> IndividualizedProgramAccommodations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramAmendment> IndividualizedProgramAmendments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramAssessment> IndividualizedProgramAssessments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramEligibility> IndividualizedProgramEligibilities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramGoal> IndividualizedProgramGoals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramMeeting> IndividualizedProgramMeetings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramProgressReport> IndividualizedProgramProgressReports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramProgressReportPlan> IndividualizedProgramProgressReportPlans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualizedProgramServicesReceived> IndividualizedProgramServicesReceiveds { get; set; }
    }
}
