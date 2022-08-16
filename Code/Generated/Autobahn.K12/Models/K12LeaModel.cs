//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12Lea Model
     /// </summary>
    public partial class K12LeaModel : AutobahnBase, Interfaces.IK12Lea
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? CharterSchoolIndicator { get; set; }

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
        public  RefLEAImprovementStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefLeaTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPublicSchoolChoiceStatusId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  SupervisoryUnionIdentificationNumber { get; set; }

    }
}
