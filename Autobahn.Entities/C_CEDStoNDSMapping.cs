using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("_CEDStoNDSMapping")]
    public partial class C_CEDStoNDSMapping
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string GlobalID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string TableName { get; set; }

        [StringLength(100)]
        public string ColumnName { get; set; }

        [StringLength(20)]
        public string Version { get; set; }
    }
}
