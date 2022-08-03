//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IRefMilitaryVeteranStudentIndicator.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IRefMilitaryVeteranStudentIndicator
     /// </summary>
    public partial interface IRefMilitaryVeteranStudentIndicator
    {
        /// <summary>
        /// Defines the RefMilitaryVeteranStudentIndicator.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

        /// <summary>
        /// Defines the RefMilitaryVeteranStudentIndicator.Code non nullable property
        /// </summary>
        System.String Code { get; set; }

        /// <summary>
        /// Defines the RefMilitaryVeteranStudentIndicator.Definition non nullable property
        /// </summary>
        System.String Definition { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefJurisdiction"/> model
        /// </summary>
        Guid? RefJurisdictionId { get; set; }

        /// <summary>
        /// Defines the RefMilitaryVeteranStudentIndicator.SortOrder nullable property
        /// </summary>
        System.Decimal? SortOrder { get; set; }

        /// <summary>
        /// Defines the RefMilitaryVeteranStudentIndicator.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the RefMilitaryVeteranStudentIndicator.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

    }
}
