//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonLanguageModel.cs
//***************************************************************************

using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonLanguage Model
     /// </summary>
    public partial class PersonLanguageModel : AutobahnBase, IPersonLanguage
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// ISO 639-2 Language Code
        /// <para>
        /// The code for the specific language or dialect that a person uses to communicate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19317">ISO 639-2 Language Code</a>
        /// </para>
        /// </summary>
        public Guid RefLanguageId { get; set; }

        /// <summary>
        /// Language Type
        /// <para>
        /// An indication of the function and context in which a person uses a language to communicate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19316">Language Type</a>
        /// </para>
        /// </summary>
        public Guid RefLanguageUseTypeId { get; set; }

    }
}
