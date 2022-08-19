using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("CompetencyFramework")]
    public partial class CompetencyFramework
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompetencyFramework()
        {
            CompetencyDefinitions = new HashSet<CompetencyDefinition>();
        }

        public int CompetencyFrameworkId { get; set; }

        [StringLength(512)]
        public string URI { get; set; }

        [StringLength(120)]
        public string Title { get; set; }

        [StringLength(30)]
        public string Subject { get; set; }

        [StringLength(30)]
        public string Version { get; set; }

        [StringLength(120)]
        public string Creator { get; set; }

        [StringLength(120)]
        public string Jurisdiction { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        [StringLength(30)]
        public string Publisher { get; set; }

        public int? RefCompetencyFrameworkPublicationStatusId { get; set; }

        [Column(TypeName = "date")]
        public DateTime ValidStartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime ValidEndDate { get; set; }

        public int? RefLanguageId { get; set; }

        [StringLength(300)]
        public string License { get; set; }

        [StringLength(300)]
        public string Rights { get; set; }

        [StringLength(30)]
        public string RightsHolder { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CompetencyFrameworkPublicationDate { get; set; }

        [StringLength(512)]
        public string CompetencyFrameworkSourceUrl { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompetencyDefinition> CompetencyDefinitions { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }

        public virtual RefCompetencyFrameworkPublicationStatus RefCompetencyFrameworkPublicationStatus { get; set; }

        public virtual RefLanguage RefLanguage { get; set; }
    }
}
