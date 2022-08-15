//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IStaffProfessionalDevelopmentActivity.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IStaffProfessionalDevelopmentActivity Interface
     /// </summary>
    public partial interface IStaffProfessionalDevelopmentActivity : IAutobahnBase
    {
        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        Guid? RefCourseCreditUnitId { get; set; }

    }
}
