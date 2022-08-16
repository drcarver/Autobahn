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
        public  RefMilitaryActiveStudentIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefMilitaryBranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RefMilitaryConnectedStudentIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefMilitaryVeteranStudentIndicatorId { get; set; }

    }
}
