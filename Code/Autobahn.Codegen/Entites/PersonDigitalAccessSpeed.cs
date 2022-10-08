using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("PersonDigitalAccessSpeed", Schema = "Person")]
    public partial class PersonDigitalAccessSpeed
    {
        [Key]
        public int PersonDigitalAccessSpeedId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? InternetDownloadSpeed { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? InternetSpeedTestDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? InternetUploadSpeed { get; set; }
        public int? PersonDigitalAccessId { get; set; }
        public int? PersonLearningDeviceId { get; set; }
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
        [InverseProperty("PersonDigitalAccessSpeeds")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonDigitalAccessId")]
        [InverseProperty("PersonDigitalAccessSpeeds")]
        public virtual PersonDigitalAccess? PersonDigitalAccess { get; set; }
        [ForeignKey("PersonLearningDeviceId")]
        [InverseProperty("PersonDigitalAccessSpeeds")]
        public virtual PersonLearningDevice? PersonLearningDevice { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonDigitalAccessSpeeds")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
