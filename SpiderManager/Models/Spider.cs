using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpiderManager.Models
{
    public class Spider : BindableBase
    {
        private string _type;
        private string _name;
        private int _milting;
        private DateTime _prevouslyEating;
        private DateTime _nextEating;

#region Properties
        public int Id { get; set; }

        public string Type
        {
            get => _type; 
            set {
                _type = value;
                RaisePropertyChanged("Type");
            }
        }

        public string Name { 
            get => _name;
            set 
            {
                _name = value;
                RaisePropertyChanged("Name");
            } 
        }

        public int Milting 
        { 
            get => _milting;
            set 
            {
                _milting = value;
                RaisePropertyChanged("Milting");
            } 
        }

        public DateTime PrevouslyEating 
        { 
            get => _prevouslyEating;
            set 
            {
                _prevouslyEating = value;
                RaisePropertyChanged("PrevouslyEating");
            } 
        }

        public DateTime NextEating 
        { 
            get => _nextEating;
            set
            {
                _nextEating = value;
            } 
        }
#endregion

        public DateTime SetNextEating() 
        {
            double interval = 0;

            if (_milting > 0 && _milting <= 5)
                interval = 2;
            else if (_milting > 5 && _milting <= 7)
                interval = 4;
            else if (_milting > 7)
                interval = 7;

            return _prevouslyEating.AddDays(interval);
        }
    }
}
