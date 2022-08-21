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
    [Table("IndividualizedProgramService")]
    public partial class IndividualizedProgramService
    {
        /// <summary>
        /// Surrogate key
        /// </summary>
        [Key]
        public int IndividualizedProgramServiceId { get; set; }
        /// <summary>
        /// Surrogate key from Person
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIndividualizedProgramPlannedServiceTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefMethodOfServiceDeliveryId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefServiceFrequencyId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? PlannedServiceDuration { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? PlannedServiceStartDate { get; set; }
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
        [InverseProperty("IndividualizedProgramServices")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("IndividualizedProgramServices")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramServices")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIndividualizedProgramPlannedServiceTypeId")]
        [InverseProperty("IndividualizedProgramServices")]
        public virtual RefIndividualizedProgramPlannedServiceType? RefIndividualizedProgramPlannedServiceType { get; set; }
        [ForeignKey("RefMethodOfServiceDeliveryId")]
        [InverseProperty("IndividualizedProgramServices")]
        public virtual RefMethodOfServiceDelivery? RefMethodOfServiceDelivery { get; set; }
        [ForeignKey("RefServiceFrequencyId")]
        [InverseProperty("IndividualizedProgramServices")]
        public virtual RefServiceFrequency? RefServiceFrequency { get; set; }
    }
}
