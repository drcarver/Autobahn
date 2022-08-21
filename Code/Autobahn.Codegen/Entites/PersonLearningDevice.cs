using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    [Table("PersonLearningDevice")]
    public partial class PersonLearningDevice
    {
        public PersonLearningDevice()
        {
            PersonDigitalAccessSpeeds = new HashSet<PersonDigitalAccessSpeed>();
        }

        [Key]
        public int PersonLearningDeviceId { get; set; }
        public int OrganizationPersonRoleId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPrimaryLearningDeviceAccessId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPrimaryLearningDeviceAwayFromSchoolId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefPrimaryLearningDeviceProviderId { get; set; }
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
        [InverseProperty("PersonLearningDevices")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("OrganizationPersonRoleId")]
        [InverseProperty("PersonLearningDevices")]
        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("PersonLearningDevices")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefPrimaryLearningDeviceAccessId")]
        [InverseProperty("PersonLearningDevices")]
        public virtual RefPrimaryLearningDeviceAccess? RefPrimaryLearningDeviceAccess { get; set; }
        [ForeignKey("RefPrimaryLearningDeviceAwayFromSchoolId")]
        [InverseProperty("PersonLearningDevices")]
        public virtual RefPrimaryLearningDeviceAwayFromSchool? RefPrimaryLearningDeviceAwayFromSchool { get; set; }
        [ForeignKey("RefPrimaryLearningDeviceProviderId")]
        [InverseProperty("PersonLearningDevices")]
        public virtual RefPrimaryLearningDeviceProvider? RefPrimaryLearningDeviceProvider { get; set; }
        [InverseProperty("PersonLearningDevice")]
        public virtual ICollection<PersonDigitalAccessSpeed> PersonDigitalAccessSpeeds { get; set; }
    }
}
