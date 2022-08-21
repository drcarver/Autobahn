﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ScafoldADatabase.Entities
{
    /// <summary>
    /// See the CEDS_Def_Desc extended property.
    /// </summary>
    [Table("ELStaffEmployment")]
    public partial class ElstaffEmployment
    {
        [Key]
        [Column("ELStaffEmploymentId")]
        public int ElstaffEmploymentId { get; set; }
        /// <summary>
        /// See the CEDS_Def_Desc extended property.
        /// </summary>
        public int StaffEmploymentId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? HoursWorkedPerWeek { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? HourlyWage { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? UnionMembershipStatus { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public bool? StaffApprovalIndicator { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefEmploymentStatusId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefWageCollectionMethodId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        public int? RefWageVerificationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefELEducationStaffClassificationId")]
        public int? RefEleducationStaffClassificationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefELEmploymentSeparationReasonId")]
        public int? RefElemploymentSeparationReasonId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column("RefELServiceProfessionalStaffClassificationId")]
        public int? RefElserviceProfessionalStaffClassificationId { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordStartDateTime { get; set; }
        /// <summary>
        /// See the CEDS_GlobalId, CEDS_Element, CEDS_URL, and CEDS_Def_Desc extended properties.
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? RecordEndDateTime { get; set; }
        public int? RecordStatusId { get; set; }
        public int? DataCollectionId { get; set; }

        [ForeignKey("DataCollectionId")]
        [InverseProperty("ElstaffEmployments")]
        public virtual DataCollection? DataCollection { get; set; }
        [ForeignKey("RecordStatusId")]
        [InverseProperty("ElstaffEmployments")]
        public virtual RecordStatus? RecordStatus { get; set; }
        [ForeignKey("RefEleducationStaffClassificationId")]
        [InverseProperty("ElstaffEmployments")]
        public virtual RefEleducationStaffClassification? RefEleducationStaffClassification { get; set; }
        [ForeignKey("RefElemploymentSeparationReasonId")]
        [InverseProperty("ElstaffEmployments")]
        public virtual RefElemploymentSeparationReason? RefElemploymentSeparationReason { get; set; }
        [ForeignKey("RefElserviceProfessionalStaffClassificationId")]
        [InverseProperty("ElstaffEmployments")]
        public virtual RefElserviceProfessionalStaffClassification? RefElserviceProfessionalStaffClassification { get; set; }
        [ForeignKey("RefEmploymentStatusId")]
        [InverseProperty("ElstaffEmployments")]
        public virtual RefEmploymentStatus? RefEmploymentStatus { get; set; }
        [ForeignKey("RefWageCollectionMethodId")]
        [InverseProperty("ElstaffEmployments")]
        public virtual RefWageCollectionMethod? RefWageCollectionMethod { get; set; }
        [ForeignKey("RefWageVerificationId")]
        [InverseProperty("ElstaffEmployments")]
        public virtual RefWageVerification? RefWageVerification { get; set; }
        [ForeignKey("StaffEmploymentId")]
        [InverseProperty("ElstaffEmployments")]
        public virtual StaffEmployment StaffEmployment { get; set; } = null!;
    }
}
