//**********************************************************
//* DomainName: Autobahn.Entity
//* FileName:   EntityBase.cs
//**********************************************************

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.Common;
using Autobahn.Interfaces;

namespace Autobahn.Entities
{
    /// <summary>
    /// The Base Entity for Autobahn
    /// </summary>
    public partial class EntityBase : IAutobahnBase
    {
        /// <summary>
        /// The Id of the entity
        /// </summary>
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Is it a deleted entity?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// Last person to modify the entity
        /// </summary>
        public Guid? ModifiedBy { get; set; } = Guid.Parse("{E6A19048-C454-4076-BCC5-F0B836388A72}");

        /// <summary>
        /// Date and time the entity was last modified
        /// </summary>
        public DateTime ModifiedOn { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control
        /// </summary>
        [Display(Name = "Record Start Date Time")]
        public DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// The end date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        [Display(Name = "Record End Date Time")]
        public DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// The record status 
        /// </summary>
        [Display(Name = "Record Start Date Time")]
        [ForeignKey("RecordStatus")]
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// The Data Collection entity
        /// </summary>
        [ForeignKey("DataCollection")]
        public Guid? DataCollectionId { get; set; }

        /// <summary>
        /// The Data Collection entity
        /// </summary>
        public virtual DataCollection DataCollection { get; set; }

        /// <summary>
        /// The record status 
        /// </summary>
        public virtual RecordStatus RecordStatus { get; set; }
    }
}
