//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IEPPresentLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The IEPPresentLevel Model
     /// </summary>
    public partial class IEPPresentLevelModel : AutobahnBase, Interfaces.IIEPPresentLevel
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? AcademicDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  FunctionalDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  GeneralEducationDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  ParentConcernDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PreschoolDescription { get; set; }

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
        public  StudentConcernDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StudentStrengthsDescription { get; set; }

    }
}
