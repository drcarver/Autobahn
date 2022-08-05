//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonCareerEducationPlanView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonCareerEducationPlanView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonCareerEducationPlanView : ContentPage
    {
        /// <summary>
        /// Inject the PersonCareerEducationPlanViewModel as the data context for the view
        /// </summary>
        public PersonCareerEducationPlanView(PersonCareerEducationPlanViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}