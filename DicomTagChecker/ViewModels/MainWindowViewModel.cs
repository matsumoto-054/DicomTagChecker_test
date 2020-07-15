using Prism.Mvvm;

namespace DicomTagChecker.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "不正Dicomタグチェッカー";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
