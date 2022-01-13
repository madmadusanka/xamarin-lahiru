using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TestLogin.Utility
{
    internal class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
    
}
