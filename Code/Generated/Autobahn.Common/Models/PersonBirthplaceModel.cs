//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonBirthplaceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonBirthplace Model
     /// </summary>
    public partial class PersonBirthplaceModel : AutobahnBase, Interfaces.IPersonBirthplace
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? RefCountryId { get; set; }

    }
}
