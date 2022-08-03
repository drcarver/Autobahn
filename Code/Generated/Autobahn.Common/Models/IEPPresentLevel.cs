//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IEPPresentLevel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The IEPPresentLevel
     /// </summary>
    public partial class IEPPresentLevel : IIEPPresentLevel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.AcademicDescription non nullable property
        /// </summary>
        public System.String AcademicDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.FunctionalDescription non nullable property
        /// </summary>
        public System.String FunctionalDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.GeneralEducationDescription non nullable property
        /// </summary>
        public System.String GeneralEducationDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.ParentConcernDescription non nullable property
        /// </summary>
        public System.String ParentConcernDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.PreschoolDescription non nullable property
        /// </summary>
        public System.String PreschoolDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.StudentConcernDescription non nullable property
        /// </summary>
        public System.String StudentConcernDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.StudentStrengthsDescription non nullable property
        /// </summary>
        public System.String StudentStrengthsDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.RecordStartDateTime nullable property
        /// </summary>
        public System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.RecordEndDateTime nullable property
        /// </summary>
        public System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}