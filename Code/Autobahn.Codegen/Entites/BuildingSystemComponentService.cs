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
    [Table("BuildingSystemComponentService", Schema = "Facilities")]
    public partial class BuildingSystemComponentService
    {
        [Key]
        public int BuildingSystemComponentServiceId { get; set; }
        public int BuildingSystemComponentId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ComponentOrFixtureScheduledServicedDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ComponentOrFixtureServicedDate { get; set; }
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

        [ForeignKey("BuildingSystemComponentId")]
        [InverseProperty("BuildingSystemComponentServices")]
        public virtual BuildingSystemComponent BuildingSystemComponent { get; set; } = null!;
        [ForeignKey("DataCollectionId")]
        [InverseProperty("BuildingSystemComponentServices")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("BuildingSystemComponentServices")]
        public virtual RecordStatus? RecordStatus { get; set; }
    }
}
