using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Gibbs
{
    class TernaryData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private double a;
        private double b;
        private double c;

        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        
        public double A
        { 
            get { return a; }
            set
            {
                if ((value + b) > 100)
                { a = 100 - b - value; }
                else
                { a = value; }

                c = 100 - a - b;
                this.NotifyPropertyChanged("A");
                this.NotifyPropertyChanged("C");
            }
        }
            
        public double B    
        {
            get { return b; }
            set 
            {
                if ((value + a) > 100)
                { b = 100 - a - value; }
                else
                { b = value; }

                c = 100 - a - b;
                this.NotifyPropertyChanged("B");
                this.NotifyPropertyChanged("C");
            }
        }
            
        public double C
        {
            get { return c; }
            //set { c = value; this.NotifyPropertyChanged("C"); }
        }
    }

    class TernaryDataList : BindingList<TernaryData>
    {

    }
}
