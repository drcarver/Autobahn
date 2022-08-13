//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The Person Model
     /// </summary>
    public partial class PersonModel : AutobahnBase, Interfaces.IPerson
    {
        /// <summary>
        /// The start date and, optionally, time that a record is active as used to support version control.
        /// </summary>
        public Guid? PersonMasterId { get; set; }

    }
}
