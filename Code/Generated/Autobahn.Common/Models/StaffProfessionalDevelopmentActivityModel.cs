//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffProfessionalDevelopmentActivityModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffProfessionalDevelopmentActivity Model
     /// </summary>
    public partial class StaffProfessionalDevelopmentActivityModel : AutobahnBase, Interfaces.IStaffProfessionalDevelopmentActivity
    {
        /// <summary>
        /// The type of credit (unit, semester, or quarter) associated with the credit hours earned for the course. 
        /// </summary>
        public Guid? RefCourseCreditUnitId { get; set; }

    }
}
