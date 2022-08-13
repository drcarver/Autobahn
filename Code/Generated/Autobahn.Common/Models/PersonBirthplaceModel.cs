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
        /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
        /// </summary>
        public System.String City { get; set; }

        /// <summary>
        /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
        /// </summary>
        public Guid? RefCountryId { get; set; }

        /// <summary>
        /// The unique two digit International Organization for Standardization (ISO) code for the country in which a person is born.
        /// </summary>
        public Guid? RefStateId { get; set; }

    }
}
