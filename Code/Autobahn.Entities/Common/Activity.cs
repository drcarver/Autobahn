//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Activity.cs
//**********************************************************

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    /// <summary>
    /// An activity, such as a co-curricular or extra-curricular
    /// activity that is offered at an education institution.
    /// </summary>
    [Table("Activity")]
    public partial class Activity : EntityBase
    {
        /// <summary>
        /// The organization sponsoring the Activity
        /// </summary>
        [ForeignKey("Organization")]
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// A description of the events and procedures that
        /// take place under the purview of an organized
        /// activity, such as a co-curricular or
        /// extra-curricular activity that is offered at
        /// an education institution.
        /// </summary>
        [Display(Name = "Activity Description")]
        [StringLength(300)]
        public string ActivityDescription { get; set; }

        /// <summary>
        /// The organization sponsoring the Activity
        /// </summary>
        public virtual Organization Organization { get; set; }
    }
}
