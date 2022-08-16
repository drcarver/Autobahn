//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentDemographicModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentDemographic Model
     /// </summary>
    public partial class PsStudentDemographicModel : AutobahnBase, Interfaces.IPsStudentDemographic
    {
        /// <summary>
        /// 
        /// </summary>
        public  ChildrenOfFallenHeroesIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  EmancipatedMinor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FirstGenerationCollegeStudent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  NumberOfDependents { get; set; }

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
        public Guid? RefCampusResidencyTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefCohortExclusionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefDependencyStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefMaternalEducationLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefNumberOfDependentsTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPaternalEducationLevelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPsLepTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTuitionResidencyTypeId { get; set; }

    }
}
