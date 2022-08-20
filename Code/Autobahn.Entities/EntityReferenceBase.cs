//**********************************************************
//* DomainName: Autobahn.Entity
//* FileName:   EntityReferenceBase.cs
//**********************************************************

using Autobahn.Entities.Common;
using Autobahn.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    /// <summary>
    /// The base type for the reference
    /// </summary>
    [Index(nameof(Code), IsUnique = true)]
    public class EntityReferenceBase : EntityBase, IReferenceBase, IPickListItem
    {
        /// <summary>
        /// The description of the reference item 
        /// </summary>
        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        /// <summary>
        /// The unique code for the reference item
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        /// <summary>
        /// The definition of the reference item
        /// </summary>
        [StringLength(4000)]
        public string Definition { get; set; }

        /// <summary>
        /// The organization that owns the reference item
        /// </summary>
        [ForeignKey("Organization")]
        public Guid? RefJurisdictionId { get; set; } = Guid.Parse("{22B1FD25-AE5C-4B03-B463-284D0C1B49F5}");

        /// <summary>
        /// The sort order for the reference items
        /// </summary>
        public decimal? SortOrder { get; set; }

        /// <summary>
        /// The organization that owns the reference item
        /// </summary>
        public virtual Organization Organization { get; set; }
    }
}
