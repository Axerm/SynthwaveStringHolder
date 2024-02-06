using SynthwaveStringHolder.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace SynthwaveStringHolder.ViewModels
{
    public class SynthwaveStringHolderViewModel : IDisposable
    {
        private bool _disposedValue;
        private DispatcherTimer _timer;

        public ObservableCollection<SynthwaveStringHolderModel> Models { get; protected set; }

        public SynthwaveStringHolderViewModel()
        {
            _disposedValue = false;

            Models = new()
            {
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                //new SynthwaveStringHolderModel(),
                new SynthwaveStringHolderModel()
            };

            _timer = new();
            _timer.Interval = TimeSpan.FromMilliseconds(300);
            _timer.Tick += (sender, e) => AnotherStart();
            _timer.Start();
        }

        public virtual void AnotherStart()
        {
            foreach (var model in Models)
            {
                //if (!model.Rotating)
                //{
                //    model.Rotating = true;
                //    model.GenerateNextDuration();
                //    model.GenerateNextAngle();
                //}

                model.GenerateNextAngle();
            }

            //Model.GenerateNextDuration();
            //Model.GenerateNextAngle();
            //_timer.Interval = Model.Duration;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _timer.Stop();
                }
                _disposedValue = true;
            }
        }

        // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
        ~SynthwaveStringHolderViewModel()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
