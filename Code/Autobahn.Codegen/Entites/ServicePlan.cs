using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("ServicePlan")]
    public partial class ServicePlan
    {
        public ServicePlan()
        {
            ServiceFrequencies = new HashSet<ServiceFrequency>();
            ServicesReceiveds = new HashSet<ServicesReceived>();
        }

        [Key]
        public int ServicePlanId { get; set; }
        public int OrganizationPersonRoleId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DeclinedServicesDate { get; set; }
        public bool? ExtendsOutsideSchoolYear { get; set; }
        public bool? InclusiveSettingIndicator { get; set; }
        public string? ReasonForDeclinedServices { get; set; }
        public string? SettingDescription { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("ServicePlans")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("ServicePlans")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ServicePlans")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("ServicePlan")]
        public virtual ICollection<ServiceFrequency> ServiceFrequencies { get; set; }
        [InverseProperty("ServicePlan")]
        public virtual ICollection<ServicesReceived> ServicesReceiveds { get; set; }
    }
}
