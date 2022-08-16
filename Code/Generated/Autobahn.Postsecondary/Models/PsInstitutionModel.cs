//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsInstitutionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsInstitution Model
     /// </summary>
    public partial class PsInstitutionModel : AutobahnBase, Interfaces.IPsInstitution
    {
        /// <summary>
        /// 
        /// </summary>
        public  InstitutionallyControlledHousingStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefAdministrativeFundingControlId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAdmissionConsiderationLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefAdmissionConsiderationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCarnegieBasicClassificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefControlOfInstitutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefIncreasedLearningTimeTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLevelOfInstitutionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPredominantCalendarSystemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTenureSystemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  VirtualIndicator { get; set; }

    }
}
