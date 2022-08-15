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
        /// An indication that the student's parent or guardian is on Active Duty, in the National Guard, or in the Reserve components of the United States military services
        /// </summary>
        Guid? RefMilitaryConnectedStudentIndicatorId { get; set; }

    }
}
