//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   EarlyChildhoodCredential.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;
using Autobahn.Entities.Common;

namespace Autobahn.Entities.EarlyLearning
{
    [Table("EarlyChildhoodCredential", Schema = "EarlyLearning")]
    public partial class EarlyChildhoodCredential : EntityBase
    {
        [ForeignKey("PersonCredential")]
        public Guid PersonCredentialId { get; set; }

        [ForeignKey("RefEarlyChildhoodCredential")]
        public Guid RefEarlyChildhoodCredentialId { get; set; }

        public virtual PersonCredential PersonCredential { get; set; }

        public virtual RefEarlyChildhoodCredential RefEarlyChildhoodCredential { get; set; }
    }
}
