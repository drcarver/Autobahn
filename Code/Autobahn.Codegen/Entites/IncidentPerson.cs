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
    [Table("IncidentPerson", Schema = "Incident")]
    public partial class IncidentPerson
    {
        [Key]
        public int IncidentPersonId { get; set; }
        public int IncidentId { get; set; }
        public int PersonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [StringLength(40)]
        public string? Identifier { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int RefIncidentPersonRoleTypeId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefIncidentPersonTypeId { get; set; }
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
        [InverseProperty("IncidentPeople")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("IncidentId")]
        [InverseProperty("IncidentPeople")]
        public virtual Incident Incident { get; set; } = null!;
        [ForeignKey("PersonId")]
        [InverseProperty("IncidentPeople")]
        public virtual Person Person { get; set; } = null!;
        [ForeignKey("RecordStatusId")]
        [InverseProperty("IncidentPeople")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefIncidentPersonRoleTypeId")]
        [InverseProperty("IncidentPeople")]
        public virtual RefIncidentPersonRoleType RefIncidentPersonRoleType { get; set; } = null!;
        [ForeignKey("RefIncidentPersonTypeId")]
        [InverseProperty("IncidentPeople")]
        public virtual RefIncidentPersonType? RefIncidentPersonType { get; set; }
    }
}
