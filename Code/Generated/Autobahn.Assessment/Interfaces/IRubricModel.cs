//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   IRubricModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Assessment.Interfaces
{
     /// <summary>
     /// The IRubricModel Interface
     /// </summary>
    public partial interface IRubricModel : IAutobahnBase
    {
        /// <summary>
        /// Defines the Rubric.Identifier non nullable property
        /// </summary>
        System.String Identifier { get; set; }

        /// <summary>
        /// Defines the Rubric.Title non nullable property
        /// </summary>
        System.String Title { get; set; }

        /// <summary>
        /// Defines the Rubric.UrlReference non nullable property
        /// </summary>
        System.String UrlReference { get; set; }

        /// <summary>
        /// Defines the Rubric.Description non nullable property
        /// </summary>
        System.String Description { get; set; }

    }
}
