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
    [Table("K12CharterSchoolAuthorizerAgency")]
    public partial class K12charterSchoolAuthorizerAgency
    {
        public K12charterSchoolAuthorizerAgency()
        {
            K12schools = new HashSet<K12school>();
        }

        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Key]
        [Column("K12CharterSchoolAuthorizerAgencyId")]
        public int K12charterSchoolAuthorizerAgencyId { get; set; }
        public int? OrganizationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefCharterSchoolAuthorizerTypeId { get; set; }
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
        [InverseProperty("K12charterSchoolAuthorizerAgencies")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("K12charterSchoolAuthorizerAgencies")]
        public virtual Organization? Organization { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12charterSchoolAuthorizerAgencies")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCharterSchoolAuthorizerTypeId")]
        [InverseProperty("K12charterSchoolAuthorizerAgencies")]
        public virtual RefCharterSchoolAuthorizerType RefCharterSchoolAuthorizerType { get; set; } = null!;
        [InverseProperty("K12charterSchoolAuthorizerAgency")]
        public virtual ICollection<K12school> K12schools { get; set; }
    }
}
