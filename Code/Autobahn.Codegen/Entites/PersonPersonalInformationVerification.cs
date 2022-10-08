using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("PersonPersonalInformationVerification", Schema = "Person")]
    public partial class PersonPersonalInformationVerification
    {
        [Key]
        public int PersonPersonalInformationVerificationId { get; set; }
        public int PersonId { get; set; }
        public int? PersonAddressId { get; set; }
        public int? PersonDetailId { get; set; }
        public int? PersonTelephoneId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPersonalInformationTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPersonalInformationVerificationId { get; set; }
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
        [InverseProperty("PersonPersonalInformationVerifications")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("PersonPersonalInformationVerifications")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("PersonAddressId")]
        [InverseProperty("PersonPersonalInformationVerifications")]
        public virtual PersonAddress? PersonAddress { get; set; }
        [ForeignKey("PersonDetailId")]
        [InverseProperty("PersonPersonalInformationVerifications")]
        public virtual PersonDetail? PersonDetail { get; set; }
        [ForeignKey("PersonTelephoneId")]
        [InverseProperty("PersonPersonalInformationVerifications")]
        public virtual PersonTelephone? PersonTelephone { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonPersonalInformationVerifications")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefPersonalInformationTypeId")]
        [InverseProperty("PersonPersonalInformationVerifications")]
        public virtual RefPersonalInformationType? RefPersonalInformationType { get; set; }
        [ForeignKey("RefPersonalInformationVerificationId")]
        [InverseProperty("PersonPersonalInformationVerifications")]
        public virtual RefPersonalInformationVerification? RefPersonalInformationVerification { get; set; }
    }
}
