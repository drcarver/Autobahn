using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("PersonOtherName")]
    public partial class PersonOtherName
    {
        public int PersonOtherNameId { get; set; }

        public int PersonId { get; set; }

        public int? RefOtherNameTypeId { get; set; }

        [StringLength(40)]
        public string OtherName { get; set; }

        [StringLength(35)]
        public string FirstName { get; set; }

        [StringLength(35)]
        public string MiddleName { get; set; }

        [StringLength(35)]
        public string LastName { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public Guid? RecordStatusId { get; set; }

        public Guid? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual Person Person { get; set; }

        public virtual RefOtherNameType RefOtherNameType { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
