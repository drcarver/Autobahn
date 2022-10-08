using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("PersonDigitalAccess", Schema = "Person")]
    public partial class PersonDigitalAccess
    {
        public PersonDigitalAccess()
        {
            PersonDigitalAccessSpeeds = new HashSet<PersonDigitalAccessSpeed>();
        }

        [Key]
        public int PersonDigitalAccessId { get; set; }
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? InternetAccessInResidence { get; set; }
        public int? PersonAddressId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefBarrierToInternetAccessInResidenceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefInternetAccessTypeInResidenceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefInternetPerformanceInResidenceId { get; set; }
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
        [InverseProperty("PersonDigitalAccesses")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("PersonDigitalAccesses")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("PersonAddressId")]
        [InverseProperty("PersonDigitalAccesses")]
        public virtual PersonAddress? PersonAddress { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonDigitalAccesses")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefBarrierToInternetAccessInResidenceId")]
        [InverseProperty("PersonDigitalAccesses")]
        public virtual RefBarrierToInternetAccessInResidence? RefBarrierToInternetAccessInResidence { get; set; }
        [ForeignKey("RefInternetAccessTypeInResidenceId")]
        [InverseProperty("PersonDigitalAccesses")]
        public virtual RefInternetAccessTypeInResidence? RefInternetAccessTypeInResidence { get; set; }
        [ForeignKey("RefInternetPerformanceInResidenceId")]
        [InverseProperty("PersonDigitalAccesses")]
        public virtual RefInternetPerformanceInResidence? RefInternetPerformanceInResidence { get; set; }
        [InverseProperty("PersonDigitalAccess")]
        public virtual ICollection<PersonDigitalAccessSpeed> PersonDigitalAccessSpeeds { get; set; }
    }
}
