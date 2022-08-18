//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonMilitaryModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonMilitary Model
     /// </summary>
    public partial class PersonMilitaryModel : AutobahnBase, Interfaces.IPersonMilitary
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryActiveStudentIndicator"/> model
        /// </summary>
        public Guid? RefMilitaryActiveStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryBranch"/> model
        /// </summary>
        public Guid? RefMilitaryBranchId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryConnectedStudentIndicator"/> model
        /// </summary>
        public Guid? RefMilitaryConnectedStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryVeteranStudentIndicator"/> model
        /// </summary>
        public Guid? RefMilitaryVeteranStudentIndicatorId { get; set; }

    }
}
