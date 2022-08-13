//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonMilitaryModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonMilitary Model
     /// </summary>
    public partial class PersonMilitaryModel : AutobahnBase, Interfaces.IPersonMilitary
    {
        /// <summary>
        /// An indication that the student's parent or guardian is on Active Duty, in the National Guard, or in the Reserve components of the United States military services
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// An indication that the student's parent or guardian is on Active Duty, in the National Guard, or in the Reserve components of the United States military services
        /// </summary>
        public Guid? RefMilitaryActiveStudentIndicatorId { get; set; }

        /// <summary>
        /// An indication that the student's parent or guardian is on Active Duty, in the National Guard, or in the Reserve components of the United States military services
        /// </summary>
        public Guid? RefMilitaryBranchId { get; set; }

        /// <summary>
        /// An indication that the student's parent or guardian is on Active Duty, in the National Guard, or in the Reserve components of the United States military services
        /// </summary>
        public Guid? RefMilitaryConnectedStudentIndicatorId { get; set; }

        /// <summary>
        /// An indication that the student's parent or guardian is on Active Duty, in the National Guard, or in the Reserve components of the United States military services
        /// </summary>
        public Guid? RefMilitaryVeteranStudentIndicatorId { get; set; }

    }
}
