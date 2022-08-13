//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonStatusModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonStatus Model
     /// </summary>
    public partial class PersonStatusModel : AutobahnBase, Interfaces.IPersonStatus
    {
        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        public Guid RefPersonStatusTypeId { get; set; }

        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        public System.DateTime? StatusEndDate { get; set; }

        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        public System.DateTime? StatusStartDate { get; set; }

        /// <summary>
        /// An indication that the student met the State criteria for classification as having an economic disadvantage.
        /// </summary>
        public System.Boolean StatusValue { get; set; }

    }
}
