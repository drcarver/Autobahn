//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.LearningResources.Models
{
     /// <summary>
     /// The LearningResource Model
     /// </summary>
    public partial class LearningResourceModel : AutobahnBase, Interfaces.ILearningResource
    {
        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// </summary>
        public System.String Url { get; set; }

    }
}
