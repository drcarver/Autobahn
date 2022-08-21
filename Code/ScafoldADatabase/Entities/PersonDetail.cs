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
    [Table("PersonDetail")]
    [Index("PersonId", Name = "IX_PersonId")]
    public partial class PersonDetail
    {
        public PersonDetail()
        {
            PersonPersonalInformationVerifications = new HashSet<PersonPersonalInformationVerification>();
        }

        [Key]
        public int PersonDetailId { get; set; }
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(75)]
        public string? FirstName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(75)]
        public string? MiddleName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(75)]
        public string LastName { get; set; } = null!;
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(10)]
        public string? GenerationCode { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? Prefix { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? Birthdate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefSexId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? HispanicLatinoEthnicity { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefUSCitizenshipStatusId")]
        public int? RefUscitizenshipStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefVisaTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefStateOfResidenceId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefProofOfResidencyTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefHighestEducationLevelCompletedId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? BirthdateVerification { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefTribalAffiliationId { get; set; }
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
        [InverseProperty("PersonDetails")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("PersonDetails")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonDetails")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefHighestEducationLevelCompletedId")]
        [InverseProperty("PersonDetails")]
        public virtual RefEducationLevel? RefHighestEducationLevelCompleted { get; set; }
        [ForeignKey("RefProofOfResidencyTypeId")]
        [InverseProperty("PersonDetails")]
        public virtual RefProofOfResidencyType? RefProofOfResidencyType { get; set; }
        [ForeignKey("RefSexId")]
        [InverseProperty("PersonDetails")]
        public virtual RefSex? RefSex { get; set; }
        [ForeignKey("RefStateOfResidenceId")]
        [InverseProperty("PersonDetails")]
        public virtual RefState? RefStateOfResidence { get; set; }
        [ForeignKey("RefTribalAffiliationId")]
        [InverseProperty("PersonDetails")]
        public virtual RefTribalAffiliation? RefTribalAffiliation { get; set; }
        [ForeignKey("RefUscitizenshipStatusId")]
        [InverseProperty("PersonDetails")]
        public virtual RefUscitizenshipStatus? RefUscitizenshipStatus { get; set; }
        [ForeignKey("RefVisaTypeId")]
        [InverseProperty("PersonDetails")]
        public virtual RefVisaType? RefVisaType { get; set; }
        [InverseProperty("PersonDetail")]
        public virtual ICollection<PersonPersonalInformationVerification> PersonPersonalInformationVerifications { get; set; }
    }
}
