//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAssessmentPersonalNeedsProfileModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAssessmentPersonalNeedsProfile Model
     /// </summary>
    public partial class PersonAssessmentPersonalNeedsProfileModel : AutobahnBase, Interfaces.IPersonAssessmentPersonalNeedsProfile
    {
        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? RecordStartDateTime { get; set; }

    }
}
