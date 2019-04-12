using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TinyEd.Helpers
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string PropertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        protected virtual void Set<T>(ref T field, T value, [CallerMemberName]string PropertyName = null)
        {
            // if (field != value)
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(PropertyName);
            }
        }
    }
}
