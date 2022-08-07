//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaTitleISupportServiceView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaTitleISupportServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaTitleISupportServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LeaTitleISupportServiceViewModel as the data context for the view
        /// </summary>
        public K12LeaTitleISupportServiceView(IK12LeaTitleISupportServiceViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
