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
    [Table("K12CharterSchoolManagementOrganization")]
    public partial class K12charterSchoolManagementOrganization
    {
        public K12charterSchoolManagementOrganization()
        {
            K12schools = new HashSet<K12school>();
        }

        [Key]
        [Column("K12CharterSchoolManagementOrganizationId")]
        public int K12charterSchoolManagementOrganizationId { get; set; }
        public int? OrganizationId { get; set; }
        public int? RefCharterSchoolManagementOrganizationTypeId { get; set; }
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
        [InverseProperty("K12charterSchoolManagementOrganizations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationId")]
        [InverseProperty("K12charterSchoolManagementOrganizations")]
        public virtual Organization? Organization { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("K12charterSchoolManagementOrganizations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefCharterSchoolManagementOrganizationTypeId")]
        [InverseProperty("K12charterSchoolManagementOrganizations")]
        public virtual RefCharterSchoolManagementOrganizationType? RefCharterSchoolManagementOrganizationType { get; set; }
        [InverseProperty("K12charterSchoolManagementOrganization")]
        public virtual ICollection<K12school> K12schools { get; set; }
    }
}
