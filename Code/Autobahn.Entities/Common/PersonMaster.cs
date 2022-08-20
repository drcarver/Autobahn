//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonMaster.cs
//**********************************************************

using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities.Common
{
    [Table("PersonMaster", Schema = "Common")]
    public partial class PersonMaster : EntityBase
    {
    }
}