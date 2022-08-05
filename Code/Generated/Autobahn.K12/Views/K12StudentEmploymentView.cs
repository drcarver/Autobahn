//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentEmploymentView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12StudentEmploymentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12StudentEmploymentView : ContentPage
    {
        /// <summary>
        /// Inject the K12StudentEmploymentViewModel as the data context for the view
        /// </summary>
        public K12StudentEmploymentView(K12StudentEmploymentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
