//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramAccommodationSubjectModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IndividualizedProgramAccommodationSubject Model
     /// </summary>
    public partial class IndividualizedProgramAccommodationSubjectModel : AutobahnBase, Interfaces.IIndividualizedProgramAccommodationSubject
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
        public Guid? RefSCEDCourseSubjectAreaId { get; set; }

    }
}
