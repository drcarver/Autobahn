//**********************************************************
//* DomainName: Autobahn.Entity
//* FileName:   EntityReferenceBase.cs
//**********************************************************

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Autobahn.Entities
{
    [Index(nameof(Code), IsUnique = true)]
    public class EntityReferenceBase : EntityBase
    {
        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(4000)]
        public string Definition { get; set; }

        public Guid? RefJurisdictionId { get; set; } = Guid.Parse("{22B1FD25-AE5C-4B03-B463-284D0C1B49F5}");

        public decimal? SortOrder { get; set; }
    }
}
