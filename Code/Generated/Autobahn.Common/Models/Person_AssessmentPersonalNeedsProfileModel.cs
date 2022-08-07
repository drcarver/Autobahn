//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   Person_AssessmentPersonalNeedsProfileModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Person_AssessmentPersonalNeedsProfile Model
     /// </summary>
    public partial class Person_AssessmentPersonalNeedsProfileModel : AutobahnBase, Interfaces.IPerson_AssessmentPersonalNeedsProfileModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentPersonalNeedsProfile"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollection"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

    }
}
