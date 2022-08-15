//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEmploymentModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffEmployment Model
     /// </summary>
    public partial class StaffEmploymentModel : AutobahnBase, Interfaces.IStaffEmployment
    {
        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// </summary>
        public System.Decimal? FullTimeEquivalency { get; set; }

    }
}
