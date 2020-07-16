using Prism.Mvvm;
using Reactive.Bindings;
using System.Windows.Controls;

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

        public ReactiveProperty<string> FolderPath { get; private set; } = new ReactiveProperty<string>(string.Empty);

        public ReactiveCommand<TextBox> SelectFolderButton { get; }

        public ReactiveProperty<string> Log { get; } = new ReactiveProperty<string>();

        public ReactiveCommand StartButton { get; }

        public ReactiveCommand CancelButton { get; }

        public MainWindowViewModel()
        {
            this.FolderPath = new ReactiveProperty<string>("");
            this.SelectFolderButton = new ReactiveCommand<TextBox>()
                .WithSubscribe(textBox => this.SelectFolder(textBox));
        }

        private void SelectFolder(TextBox textBox)
        {
            textBox.Text = "test";
        }

        private void StartReading()
        {
        }
    }
}