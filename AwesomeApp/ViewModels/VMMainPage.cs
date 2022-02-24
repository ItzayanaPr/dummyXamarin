using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace AwesomeApp.ViewModels
{
    public class VMMainPage : INotifyPropertyChanged
    {
        private Command _cmdGallery { get; set; }
        public Command CmdGallery
        {
            get { return _cmdGallery; }
            set {
                _cmdGallery = value;
                OnPropertyChanged();
            }
        }
        private string _infoMessage { get; set; }
        public string infoMessage
        {
            get { return _infoMessage; }
            set
            {
                _infoMessage = value;
                OnPropertyChanged();
            }
        }
        public VMMainPage()
        {
            infoMessage = "Press any button";
            CmdGallery = new Command<string>(execute: (string arg) =>
            {
                if (string.IsNullOrWhiteSpace(arg))
                    infoMessage = "Gallery button pressed!";
                else
                    infoMessage = arg + " button Pressed!";
            });
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;
            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
