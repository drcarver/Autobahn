//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PDActivityEducationLevelView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PDActivityEducationLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PDActivityEducationLevelView : ContentPage
    {
        /// <summary>
        /// Inject the PDActivityEducationLevelViewModel as the data context for the view
        /// </summary>
        public PDActivityEducationLevelView(PDActivityEducationLevelViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
