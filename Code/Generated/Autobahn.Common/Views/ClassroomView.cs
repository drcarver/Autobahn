//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ClassroomView.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The ClassroomView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClassroomView : ContentPage
    {
        /// <summary>
        /// Inject the ClassroomViewModel as the data context for the view
        /// </summary>
        public ClassroomView(ClassroomViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
