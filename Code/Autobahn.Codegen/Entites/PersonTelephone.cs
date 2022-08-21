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
    [Table("PersonTelephone")]
    public partial class PersonTelephone
    {
        public PersonTelephone()
        {
            PersonPersonalInformationVerifications = new HashSet<PersonPersonalInformationVerification>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int PersonTelephoneId { get; set; }
        /// <summary>
        /// Foreign key - Person.
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(24)]
        public string? TelephoneNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool PrimaryTelephoneNumberIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPersonTelephoneNumberTypeId { get; set; }
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
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? DoNotPublishIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTelephoneNumberListedStatusId { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("PersonTelephones")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("PersonTelephones")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonTelephones")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefPersonTelephoneNumberTypeId")]
        [InverseProperty("PersonTelephones")]
        public virtual RefPersonTelephoneNumberType? RefPersonTelephoneNumberType { get; set; }
        [ForeignKey("RefTelephoneNumberListedStatusId")]
        [InverseProperty("PersonTelephones")]
        public virtual RefTelephoneNumberListedStatus? RefTelephoneNumberListedStatus { get; set; }
        [InverseProperty("PersonTelephone")]
        public virtual ICollection<PersonPersonalInformationVerification> PersonPersonalInformationVerifications { get; set; }
    }
}
