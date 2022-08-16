//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeProviderModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The AeProvider Model
     /// </summary>
    public partial class AeProviderModel : AutobahnBase, Interfaces.IAeProvider
    {
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
        public Guid? RefLevelOfInstitutionId { get; set; }

    }
}
