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
    [Table("ServiceProvided")]
    public partial class ServiceProvided
    {
        public ServiceProvided()
        {
            ServiceProviders = new HashSet<ServiceProvider>();
        }

        [Key]
        public int ServiceProvidedId { get; set; }
        public int ServicesReceivedId { get; set; }
        public int? RefServicesId { get; set; }
        public int? RefStudentSupportServiceTypeId { get; set; }
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
        [InverseProperty("ServiceProvideds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ServiceProvideds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefServicesId")]
        [InverseProperty("ServiceProvideds")]
        public virtual RefService? RefServices { get; set; }
        [ForeignKey("RefStudentSupportServiceTypeId")]
        [InverseProperty("ServiceProvideds")]
        public virtual RefStudentSupportServiceType? RefStudentSupportServiceType { get; set; }
        [ForeignKey("ServicesReceivedId")]
        [InverseProperty("ServiceProvideds")]
        public virtual ServicesReceived ServicesReceived { get; set; } = null!;
        [InverseProperty("ServiceProvided")]
        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; }
    }
}
