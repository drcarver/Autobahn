//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The Person Model
     /// </summary>
    public partial class PersonModel : AutobahnBase, Interfaces.IPerson
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonMaster"/> model
        /// </summary>
        public Guid? PersonMasterId { get; set; }

    }
}
