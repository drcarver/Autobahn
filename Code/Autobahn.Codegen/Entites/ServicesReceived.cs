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
    [Table("ServicesReceived")]
    public partial class ServicesReceived
    {
        public ServicesReceived()
        {
            IndividualizedProgramServicesReceiveds = new HashSet<IndividualizedProgramServicesReceived>();
            ServiceProvideds = new HashSet<ServiceProvided>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int ServicesReceivedId { get; set; }
        /// <summary>
        /// Surrogate key from OrganizationPersonRole
        /// </summary>
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(3, 2)")]
        public decimal? FullTimeEquivalency { get; set; }
        public int ServicePlanId { get; set; }
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
        [InverseProperty("ServicesReceiveds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("ServicesReceiveds")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ServicesReceiveds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("ServicePlanId")]
        [InverseProperty("ServicesReceiveds")]
        public virtual ServicePlan ServicePlan { get; set; } = null!;
        [InverseProperty("ServicesReceived")]
        public virtual ICollection<IndividualizedProgramServicesReceived> IndividualizedProgramServicesReceiveds { get; set; }
        [InverseProperty("ServicesReceived")]
        public virtual ICollection<ServiceProvided> ServiceProvideds { get; set; }
    }
}
