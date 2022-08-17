//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonMilitary.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonMilitary Interface
     /// </summary>
    public partial interface IPersonMilitary : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMilitaryActiveStudentIndicator"/> model
        /// </summary>
        Guid? RefMilitaryActiveStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMilitaryBranch"/> model
        /// </summary>
        Guid? RefMilitaryBranchId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMilitaryConnectedStudentIndicator"/> model
        /// </summary>
        Guid? RefMilitaryConnectedStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefMilitaryVeteranStudentIndicator"/> model
        /// </summary>
        Guid? RefMilitaryVeteranStudentIndicatorId { get; set; }

    }
}
