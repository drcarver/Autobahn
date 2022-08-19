using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ELClassSection")]
    public partial class ELClassSection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ELClassSection()
        {
            ELClassSectionServices = new HashSet<ELClassSectionService>();
            ELEnrollments = new HashSet<ELEnrollment>();
        }

        public int ELClassSectionId { get; set; }

        public Guid OrganizationId { get; set; }

        public decimal? HoursAvailablePerDay { get; set; }

        public int? DaysAvailablePerWeek { get; set; }

        public int? ELProgramAnnualOperatingWeeks { get; set; }

        public bool? LanguageTranslationPolicy { get; set; }

        public int? GroupSize { get; set; }

        public int? RefServiceOptionId { get; set; }

        public int? RefEnvironmentSettingId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefEnvironmentSetting RefEnvironmentSetting { get; set; }

        public virtual RefServiceOption RefServiceOption { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELClassSectionService> ELClassSectionServices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELEnrollment> ELEnrollments { get; set; }
    }
}
