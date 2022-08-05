//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IIEPPresentLevel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IIEPPresentLevel
     /// </summary>
    public partial interface IIEPPresentLevel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.AcademicDescription non nullable property
        /// </summary>
        System.String AcademicDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.FunctionalDescription non nullable property
        /// </summary>
        System.String FunctionalDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.GeneralEducationDescription non nullable property
        /// </summary>
        System.String GeneralEducationDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.ParentConcernDescription non nullable property
        /// </summary>
        System.String ParentConcernDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.PreschoolDescription non nullable property
        /// </summary>
        System.String PreschoolDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.StudentConcernDescription non nullable property
        /// </summary>
        System.String StudentConcernDescription { get; set; }

        /// <summary>
        /// Defines the IEPPresentLevel.StudentStrengthsDescription non nullable property
        /// </summary>
        System.String StudentStrengthsDescription { get; set; }

    }
}
