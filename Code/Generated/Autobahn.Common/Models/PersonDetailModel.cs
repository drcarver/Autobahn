//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDetailModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonDetail Model
     /// </summary>
    public partial class PersonDetailModel : AutobahnBase, Interfaces.IPersonDetail
    {
        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.DateTime? Birthdate { get; set; }

    }
}
