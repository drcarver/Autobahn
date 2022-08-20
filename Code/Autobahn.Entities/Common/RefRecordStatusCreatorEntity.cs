//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRecordStatusCreatorEntity.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    /// <summary>
    /// The type of entity that created or indicated the Record Status Type
    /// </summary>
    [Table("RefRecordStatusCreatorEntity")]
    public partial class RefRecordStatusCreatorEntity : EntityReferenceBase
    {
        /// <summary>
        /// The Id of the creator's organization
        /// </summary>
        [ForeignKey("Organization")]
        public Guid? OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
