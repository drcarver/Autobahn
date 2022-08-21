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
    [Table("ServiceStaff")]
    [Index("OrganizationPersonRoleId", "RefSpecialEducationStaffCategoryId", Name = "IX_OrganizationPersonRole_RefSpecialEducationStaffCategory", IsUnique = true)]
    public partial class ServiceStaff
    {
        public ServiceStaff()
        {
            ServiceProviders = new HashSet<ServiceProvider>();
        }

        [Key]
        public int ServiceStaffId { get; set; }
        public int OrganizationPersonRoleId { get; set; }
        public int RefSpecialEducationStaffCategoryId { get; set; }
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
        [InverseProperty("ServiceStaffs")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("ServiceStaffs")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ServiceStaffs")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefSpecialEducationStaffCategoryId")]
        [InverseProperty("ServiceStaffs")]
        public virtual RefSpecialEducationStaffCategory RefSpecialEducationStaffCategory { get; set; } = null!;
        [InverseProperty("ServiceStaff")]
        public virtual ICollection<ServiceProvider> ServiceProviders { get; set; }
    }
}
