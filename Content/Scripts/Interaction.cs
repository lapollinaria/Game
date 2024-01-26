using Engine;
using Engine.BaseAssets.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Quest.Content.Scripts
{
    public class Interaction: BehaviourComponent, INotifyPropertyChanged
    {

        public int done;

        private string texxxt = "";

        public string TexxxtN
        {
            get => texxxt;
            set
            {
                texxxt = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        public override void Start()
        {
            done = 0;

            GraphicsCore.ViewportPanel.Dispatcher.Invoke(() =>
            {
                UserInterface UI = new UserInterface();
                GraphicsCore.ViewportPanel.Children.Add(UI);
                UI.DataContext = this;
            });

            TexxxtN = done.ToString();
        }

        public void Increment()
        {
            done++;
            Logger.Log(LogType.Info, done.ToString());

            TexxxtN = done.ToString();
            if (done == 3)
            {
                GraphicsCore.ViewportPanel.Dispatcher.Invoke(() =>
                {
                    UserControlWin UWin = new UserControlWin();
                    GraphicsCore.ViewportPanel.Children.Add(UWin);
                 
                });
            }

        }


    }
}
