//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricModel.cs
//***************************************************************************

using Autobahn.Interfaces.Assessments;
using Autobahn.Interfaces.Common;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The Rubric Model
     /// </summary>
    public partial class RubricModel : AutobahnBase, IRubric
    {
        /// <summary>
        /// Rubric Identifier
        /// <para>
        /// An identifier assigned to a rubric.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19412">Rubric Identifier</a>
        /// </para>
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// Rubric Title
        /// <para>
        /// The title of the rubric.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19411">Rubric Title</a>
        /// </para>
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Rubric URL Reference
        /// <para>
        /// The URL location where the rubric may be found.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19413">Rubric URL Reference</a>
        /// </para>
        /// </summary>
        public System.String UrlReference { get; set; }

    }
}
