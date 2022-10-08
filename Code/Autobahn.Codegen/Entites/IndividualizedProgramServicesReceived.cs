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
    [Table("IndividualizedProgramServicesReceived", Schema = "K12")]
    [Index("IndividualizedProgramId", "ServicesReceivedId", Name = "IX_IndividualizedProgram_ServicesReceived", IsUnique = true)]
    public partial class IndividualizedProgramServicesReceived
    {
        [Key]
        public int IndividualizedProgramServicesReceivedId { get; set; }
        public int IndividualizedProgramId { get; set; }
        public int ServicesReceivedId { get; set; }
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
        [InverseProperty("IndividualizedProgramServicesReceiveds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IndividualizedProgramId")]
        [InverseProperty("IndividualizedProgramServicesReceiveds")]
        public virtual IndividualizedProgram IndividualizedProgram { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IndividualizedProgramServicesReceiveds")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("ServicesReceivedId")]
        [InverseProperty("IndividualizedProgramServicesReceiveds")]
        public virtual ServicesReceived ServicesReceived { get; set; } = null!;
    }
}
