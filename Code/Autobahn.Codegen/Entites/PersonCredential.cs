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
    [Table("PersonCredential")]
    public partial class PersonCredential
    {
        public PersonCredential()
        {
            EarlyChildhoodCredentials = new HashSet<EarlyChildhoodCredential>();
            StaffCredentials = new HashSet<StaffCredential>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int PersonCredentialId { get; set; }
        /// <summary>
        /// Foreign key - Person.
        /// </summary>
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? CredentialName { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefCredentialTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? IssuanceDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "date")]
        public DateTime? ExpirationDate { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIssuingStateId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(30)]
        public string? ProfessionalCertificateOrLicenseNumber { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(60)]
        public string? CredentialOrLicenseAwardEntity { get; set; }
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
        [InverseProperty("PersonCredentials")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("PersonId")]
        [InverseProperty("PersonCredentials")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonCredentials")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCredentialTypeId")]
        [InverseProperty("PersonCredentials")]
        public virtual RefCredentialType? RefCredentialType { get; set; }
        [ForeignKey("RefIssuingStateId")]
        [InverseProperty("PersonCredentials")]
        public virtual RefState? RefIssuingState { get; set; }
        [InverseProperty("PersonCredential")]
        public virtual ICollection<EarlyChildhoodCredential> EarlyChildhoodCredentials { get; set; }
        [InverseProperty("PersonCredential")]
        public virtual ICollection<StaffCredential> StaffCredentials { get; set; }
    }
}
