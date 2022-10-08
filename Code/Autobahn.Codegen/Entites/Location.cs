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
    [Table("Location", Schema = "Core")]
    public partial class Location
    {
        public Location()
        {
            AssessmentParticipantSessions = new HashSet<AssessmentParticipantSession>();
            Classrooms = new HashSet<Classroom>();
            FacilityLocations = new HashSet<FacilityLocation>();
            LocationAddresses = new HashSet<LocationAddress>();
            OrganizationLocations = new HashSet<OrganizationLocation>();
        }

        /// <summary>
        /// Surrogate Key
        /// </summary>
        [Key]
        public int LocationId { get; set; }
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
        [InverseProperty("Locations")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("Locations")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [InverseProperty("Location")]
        public virtual ICollection<AssessmentParticipantSession> AssessmentParticipantSessions { get; set; }
        [InverseProperty("Location")]
        public virtual ICollection<Classroom> Classrooms { get; set; }
        [InverseProperty("Location")]
        public virtual ICollection<FacilityLocation> FacilityLocations { get; set; }
        [InverseProperty("Location")]
        public virtual ICollection<LocationAddress> LocationAddresses { get; set; }
        [InverseProperty("Location")]
        public virtual ICollection<OrganizationLocation> OrganizationLocations { get; set; }
    }
}
