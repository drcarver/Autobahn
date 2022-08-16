//**********************************************************
//* DomainName: Competencies
//* FileName:   CompetencyFrameworkModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Competencies.Models
{
     /// <summary>
     /// The CompetencyFramework Model
     /// </summary>
    public partial class CompetencyFrameworkModel : AutobahnBase, Interfaces.ICompetencyFramework
    {
        /// <summary>
        /// 
        /// </summary>
        public  CompetencyFrameworkPublicationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  CompetencyFrameworkSourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Creator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Jurisdiction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  License { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Publisher { get; set; }

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
        public  RefCompetencyFrameworkPublicationStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLanguageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Rights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RightsHolder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Subject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? URI { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ValidEndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ValidStartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Version { get; set; }

    }
}
