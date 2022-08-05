//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonMilitary.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonMilitary
     /// </summary>
    public partial class PersonMilitary : AutobahnBase, Interfaces.IPersonMilitary
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryActiveStudentIndicator"/> model
        /// </summary>
        public Guid? RefMilitaryActiveStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryConnectedStudentIndicator"/> model
        /// </summary>
        public Guid? RefMilitaryConnectedStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryVeteranStudentIndicator"/> model
        /// </summary>
        public Guid? RefMilitaryVeteranStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryBranch"/> model
        /// </summary>
        public Guid? RefMilitaryBranchId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
