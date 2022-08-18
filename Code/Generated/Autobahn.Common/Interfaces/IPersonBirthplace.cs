//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonBirthplace.cs
//* Name:       City of Birth
//* Definition: 
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IPersonBirthplace : IAutobahnBase
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
        System.String City { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCountry"/> model
        /// </summary>
        Guid? RefCountryId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefState"/> model
        /// </summary>
        Guid? RefStateId { get; set; }

    }
}
