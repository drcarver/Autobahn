//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonBirthplaceModel.cs
//* Name:       City of Birth
//* Definition:  The name of the city in which a person was born.
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     ///  The name of the city in which a person was born.
     /// </summary>
    public partial class PersonBirthplaceModel : AutobahnBase, Interfaces.IPersonBirthplace
    {
        /// <summary>
        /// City of Birth
        /// <para>
        ///  The name of the city in which a person was born.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19416">City of Birth</a>
        /// </para>
        /// </summary>
        public System.String City { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCountry"/> model
        /// </summary>
        public Guid? RefCountryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefState"/> model
        /// </summary>
        public Guid? RefStateId { get; set; }

    }
}
