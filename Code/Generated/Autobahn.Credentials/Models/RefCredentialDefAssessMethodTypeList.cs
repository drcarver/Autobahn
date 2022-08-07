//**********************************************************
//* DomainName: Autobahn.Credentials
//* FileName:   RefCredentialDefAssessMethodTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Credentials.Models
{
     /// <summary>
     /// The list of RefCredentialDefAssessMethodType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCredentialDefAssessMethodTypeModel"> List
         /// </summary>
        public static List<RefCredentialDefAssessMethodTypeModel> RefCredentialDefAssessMethodTypeList = new List<RefCredentialDefAssessMethodTypeModel>
        {
            new RefCredentialDefAssessMethodType { Id=Guid.Parse("d74422ce-a812-4a6f-b91e-7ea72c29898c"), Code="Artifact", Description="Artifact", Definition="A work or product created to be persistent in some medium. Artifact includes, but is not limited to, an academic paper, video documentary, computer software, music composition, choreography, novel, short story, journal article, news article, report, lesson plan, product design, manufactured product, etc. Methods of evaluation may include multiple evaluators either individually or as an expert panel using general criteria or more structured rubrics whose scores are combined, etc. Criteria and methods of evaluation are often very similar to those for assessing a performance, without the facets specific to a live performance.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefAssessMethodType { Id=Guid.Parse("91e1b288-2ce8-49bf-9849-08667dafa586"), Code="Exam", Description="Exam", Definition="A mix of scored items presented in fixed or open response formats.  Exams may be human- or machine-scored and include, but are not limited to, multiple choice, true-false, written essay, short-answer, fill-in or oral response formats that could include measurements of reasoning, problem-solving, critical thinking.", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefAssessMethodType { Id=Guid.Parse("7e8605da-5802-427a-8554-eb19f60f92df"), Code="Performance", Description="Performance", Definition="A demonstration or performance that is usually assessed while the performance is taking place or as recorded for assessment purposes after the performance.  Performance includes, but is not limited to, dance, music, teaching, acting, medical procedures, truck driving, manufacturing production, etc. Criteria include the categories and benchmarks on which the performance is assessed. Methods of evaluation can include multiple evaluators either individually or as an expert panel using general criteria or more structured rubrics whose scores are combined.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefCredentialDefAssessMethodType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCredentialDefAssessMethodTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCredentialDefAssessMethodType { Id=Guid.Parse("d74422ce-a812-4a6f-b91e-7ea72c29898c"), Description="Artifact", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefAssessMethodType { Id=Guid.Parse("91e1b288-2ce8-49bf-9849-08667dafa586"), Description="Exam", SortOrder=Convert.ToDecimal("") },
            new RefCredentialDefAssessMethodType { Id=Guid.Parse("7e8605da-5802-427a-8554-eb19f60f92df"), Description="Performance", SortOrder=Convert.ToDecimal("") },
       };
   }
}
