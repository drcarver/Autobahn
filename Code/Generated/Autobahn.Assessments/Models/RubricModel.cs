//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Assessments.Models
{
     /// <summary>
     /// The Rubric Model
     /// </summary>
    public partial class RubricModel : AutobahnBase, Interfaces.IRubric
    {
        /// <summary>
        /// The title of the rubric.
        /// </summary>
        public System.String Identifier { get; set; }

        /// <summary>
        /// The title of the rubric.
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// The title of the rubric.
        /// </summary>
        public System.String UrlReference { get; set; }

    }
}
