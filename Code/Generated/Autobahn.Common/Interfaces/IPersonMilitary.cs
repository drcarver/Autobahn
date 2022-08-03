//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPersonMilitary.cs
//**********************************************************

namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonMilitary
     /// </summary>
    public partial interface IPersonMilitary
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryActiveStudentIndicator"/> model
        /// </summary>
        Guid? RefMilitaryActiveStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryConnectedStudentIndicator"/> model
        /// </summary>
        Guid? RefMilitaryConnectedStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryVeteranStudentIndicator"/> model
        /// </summary>
        Guid? RefMilitaryVeteranStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryBranch"/> model
        /// </summary>
        Guid? RefMilitaryBranchId { get; set; }

        /// <summary>
        /// Defines the PersonMilitary.RecordStartDateTime nullable property
        /// </summary>
        System.DateTime? RecordStartDateTime { get; set; }

        /// <summary>
        /// Defines the PersonMilitary.RecordEndDateTime nullable property
        /// </summary>
        System.DateTime? RecordEndDateTime { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatus"/> model
        /// </summary>
        Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        Guid? DataCollectionId { get; set; }

    }
}
