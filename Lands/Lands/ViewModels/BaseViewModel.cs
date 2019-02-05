
namespace Lands.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class BaseViewModel : InotifyPropertyChanged
    {
        public Event PropertyChangedEventHandler PropertyChanged;
       
        protected void OnPropertyChanged([CallerMemberName] String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void SetValue<T>(ref T bakingfield, T value, [CallerMemberName] String propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(bakingfield, value))
            {
                return;
            }

            bakingfield = value;
            OnPropertyChanged(propertyName);
        }
    }
}
