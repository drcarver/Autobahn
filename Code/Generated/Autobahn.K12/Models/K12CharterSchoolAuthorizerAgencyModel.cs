//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12CharterSchoolAuthorizerAgencyModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12CharterSchoolAuthorizerAgency Model
     /// </summary>
    public partial class K12CharterSchoolAuthorizerAgencyModel : AutobahnBase, Interfaces.IK12CharterSchoolAuthorizerAgency
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? K12CharterSchoolAuthorizerAgencyId { get; set; }

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
        public  RefCharterSchoolAuthorizerTypeId { get; set; }

    }
}
