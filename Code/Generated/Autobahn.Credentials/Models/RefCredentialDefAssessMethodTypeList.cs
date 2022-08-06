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
        /// The complete <see cref="RefCredentialDefAssessMethodType"> List
         /// </summary>
        public static List<RefCredentialDefAssessMethodType> RefCredentialDefAssessMethodTypeList = new List<RefCredentialDefAssessMethodType> =
        {
            new RefCredentialDefAssessMethodType { Id=Guid.Parse("3a50d9ff-44f1-4f72-a994-0eb8ff8f9123"), Code="A work or product created to be persistent in some medium. Artifact includes, but is not limited to, an academic paper, video documentary, computer software, music composition, choreography, novel, short story, journal article, news article, report, lesson plan, product design, manufactured product, etc. Methods of evaluation may include multiple evaluators either individually or as an expert panel using general criteria or more structured rubrics whose scores are combined, etc. Criteria and methods of evaluation are often very similar to those for assessing a performance, without the facets specific to a live performance.", Description="Artifact", Definition="", SortOrder=0 },
            new RefCredentialDefAssessMethodType { Id=Guid.Parse("488068ae-5ebe-4d38-97e6-eba5947eff0d"), Code="A mix of scored items presented in fixed or open response formats.  Exams may be human- or machine-scored and include, but are not limited to, multiple choice, true-false, written essay, short-answer, fill-in or oral response formats that could include measurements of reasoning, problem-solving, critical thinking.", Description="Exam", Definition="", SortOrder=0 },
            new RefCredentialDefAssessMethodType { Id=Guid.Parse("7cfe2da9-1378-4b4c-9f70-7ffc73b30f86"), Code="A demonstration or performance that is usually assessed while the performance is taking place or as recorded for assessment purposes after the performance.  Performance includes, but is not limited to, dance, music, teaching, acting, medical procedures, truck driving, manufacturing production, etc. Criteria include the categories and benchmarks on which the performance is assessed. Methods of evaluation can include multiple evaluators either individually or as an expert panel using general criteria or more structured rubrics whose scores are combined.", Description="Performance", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCredentialDefAssessMethodType Pick List
         /// </summary>
        public static List<RefCredentialDefAssessMethodType> RefCredentialDefAssessMethodTypePickList = new List<RefCredentialDefAssessMethodType> =
        {
            new RefCredentialDefAssessMethodType { Id=Guid.Parse("3a50d9ff-44f1-4f72-a994-0eb8ff8f9123"), Code="A work or product created to be persistent in some medium. Artifact includes, but is not limited to, an academic paper, video documentary, computer software, music composition, choreography, novel, short story, journal article, news article, report, lesson plan, product design, manufactured product, etc. Methods of evaluation may include multiple evaluators either individually or as an expert panel using general criteria or more structured rubrics whose scores are combined, etc. Criteria and methods of evaluation are often very similar to those for assessing a performance, without the facets specific to a live performance.", SortOrder=0 },
            new RefCredentialDefAssessMethodType { Id=Guid.Parse("488068ae-5ebe-4d38-97e6-eba5947eff0d"), Code="A mix of scored items presented in fixed or open response formats.  Exams may be human- or machine-scored and include, but are not limited to, multiple choice, true-false, written essay, short-answer, fill-in or oral response formats that could include measurements of reasoning, problem-solving, critical thinking.", SortOrder=0 },
            new RefCredentialDefAssessMethodType { Id=Guid.Parse("7cfe2da9-1378-4b4c-9f70-7ffc73b30f86"), Code="A demonstration or performance that is usually assessed while the performance is taking place or as recorded for assessment purposes after the performance.  Performance includes, but is not limited to, dance, music, teaching, acting, medical procedures, truck driving, manufacturing production, etc. Criteria include the categories and benchmarks on which the performance is assessed. Methods of evaluation can include multiple evaluators either individually or as an expert panel using general criteria or more structured rubrics whose scores are combined.", SortOrder=0 },
       };
   }
}
