using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autobahn.Entities
{
    [Table("K12StudentHomeLanguageSurvey")]
    public partial class K12StudentHomeLanguageSurvey
    {
        public int K12StudentHomeLanguageSurveyId { get; set; }

        public int OrganizationPersonRoleId { get; set; }

        public DateTime? HomeLanguageSurveyAdministrationDate { get; set; }

        public bool? HomeLanguageSurveyAdministrationIndicator { get; set; }

        public DateTime? RecordStartDateTime { get; set; }

        public DateTime? RecordEndDateTime { get; set; }

        public int? RecordStatusId { get; set; }

        public int? DataCollectionId { get; set; }

        public virtual DataCollection DataCollection { get; set; }

        public virtual OrganizationPersonRole OrganizationPersonRole { get; set; }

        public virtual RecordStatus RecordStatus { get; set; }
    }
}
