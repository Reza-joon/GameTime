using System.ComponentModel;

namespace GameTime.ViewModels
{
 
    public class BaseINotify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        
        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
