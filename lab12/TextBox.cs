
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace lab12
{
    public class TextBox : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int _length = 100;

        public int Length
        {
            get { return _length; }
            set { 
                _length = value;
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
