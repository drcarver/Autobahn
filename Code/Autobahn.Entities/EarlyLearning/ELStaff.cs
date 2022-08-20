//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   ELStaff.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.Common;

namespace Autobahn.Entities.EarlyLearning
{
    [Table("ELStaff", Schema = "EarlyLearning")]
    public partial class ELStaff : EntityBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ELStaff()
        {
            ELStaffEducations = new HashSet<ELStaffEducation>();
        }

        [ForeignKey("OrganizationPersonRole")]
        public Guid OrganizationPersonRoleId { get; set; }

        [ForeignKey("RefChildDevelopmentAssociateType")]
        public Guid? RefChildDevelopmentAssociateTypeId { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RefChildDevelopmentAssociateType RefChildDevelopmentAssociateType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ELStaffEducation> ELStaffEducations { get; set; }
    }
}
