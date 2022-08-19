using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PsInstitution")]
    public partial class PsInstitution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PsInstitution()
        {
            PsPriceOfAttendances = new HashSet<PsPriceOfAttendance>();
        }

        public int PsInstitutionId { get; set; }

        public Guid OrganizationId { get; set; }

        public bool? VirtualIndicator { get; set; }

        public bool? InstitutionallyControlledHousingStatus { get; set; }

        public int? RefCarnegieBasicClassificationId { get; set; }

        public int? RefControlOfInstitutionId { get; set; }

        public int? RefLevelOfInstitutionId { get; set; }

        public int? RefPredominantCalendarSystemId { get; set; }

        public int? RefTenureSystemId { get; set; }

        public int? RefAdmissionConsiderationLevelId { get; set; }

        public int? RefAdmissionConsiderationTypeId { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RefAdministrativeFundingControlId { get; set; }

        public int? RefIncreasedLearningTimeTypeId { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefAdministrativeFundingControl RefAdministrativeFundingControl { get; set; }

        public virtual RefAdmissionConsiderationLevel RefAdmissionConsiderationLevel { get; set; }

        public virtual RefAdmissionConsiderationType RefAdmissionConsiderationType { get; set; }

        public virtual RefCarnegieBasicClassification RefCarnegieBasicClassification { get; set; }

        public virtual RefControlOfInstitution RefControlOfInstitution { get; set; }

        public virtual RefIncreasedLearningTimeType RefIncreasedLearningTimeType { get; set; }

        public virtual RefLevelOfInstitution RefLevelOfInstitution { get; set; }

        public virtual RefPredominantCalendarSystem RefPredominantCalendarSystem { get; set; }

        public virtual RefTenureSystem RefTenureSystem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PsPriceOfAttendance> PsPriceOfAttendances { get; set; }
    }
}
