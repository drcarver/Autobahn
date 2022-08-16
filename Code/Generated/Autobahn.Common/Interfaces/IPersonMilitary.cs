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
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMilitaryActiveStudentIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMilitaryBranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RefMilitaryConnectedStudentIndicatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefMilitaryVeteranStudentIndicatorId { get; set; }

    }
}
