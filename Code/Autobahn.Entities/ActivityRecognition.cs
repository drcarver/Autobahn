//**********************************************************
//* DomainName: Autobahn.Entity
//* FileName:   ActivityRecognition.cs
//**********************************************************
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("ActivityRecognition")]
    public partial class ActivityRecognition : EntityBase
    {
        [ForeignKey("OrganizationPersonRole")]
        public int OrganizationPersonRoleId { get; set; }

        [ForeignKey("RefActivityRecognition")]
        public Guid RefActivityRecognitionTypeId { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RefActivityRecognitionType RefActivityRecognitionType { get; set; }
    }
}
