using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace SynthwaveStringHolder.Models
{
    public class SynthwaveStringHolderModel : INotifyPropertyChanged
    {
        protected Random _generator = new();

        //public bool Rotating { get; set; } = false;

        private double _angle = 0;
        public double Angle
        {
            get { return _angle; }
            protected set
            {
                _angle = value;
                OnPropertyChanged("Angle");
            }
        }

        private TimeSpan _duration = TimeSpan.FromMilliseconds(300);
        public TimeSpan Duration
        {
            get { return _duration; }
            protected set
            {
                _duration = value;
                OnPropertyChanged("Duration");
            }
        }

        public double GenerateNextAngle() => Angle = _generator.Next(-270, 270); // _generator.Next(-720, 720);
        //public TimeSpan GenerateNextDuration() => Duration = TimeSpan.FromMilliseconds(_generator.Next(500, 1500));

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
