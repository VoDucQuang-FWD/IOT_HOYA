using Hoya.Model;
using Hoya.View;
using IOT.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hoya.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public string _imageiot;
        public string imageiot
        {
            get => _imageiot;
            set => SetProperty(ref _imageiot, value, nameof(imageiot));
        }
       public ICommand DBHOYA { get; set; }
        public ICommand Loaded { get; set; }
        public MainViewModel()
        {
            
            Loaded = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    string Systemconfigmageiot = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\iot.png";
                    imageiot = Systemconfigmageiot;
                }
                catch (Exception ex)
                {

                   
                }
               
            });
            DBHOYA = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    Loading_Indicator.BeingBusy();
                    DBHOYAView dBHOYAView = new DBHOYAView();
                    dBHOYAView.ShowDialog();
                }
                catch (Exception ex)
                {
                 
                    DBHOYAView dBHOYAView = new DBHOYAView();
                    dBHOYAView.Close();
                    Loading_Indicator.Finished();
                }

            });
        }
        public static class Loading_Indicator
        {
            private static LoadingView loading;
            public static LoadingView Loading
            {
                get
                {
                    return loading;
                }
                set
                {
                    loading = value;
                }
            }
            public static void BeingBusy()
            {
                try
                {
                    Thread thread = new Thread(() =>
                    {
                        Loading = new LoadingView();
                        Loading.ShowDialog();

                    });
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
                catch (Exception)
                {
                    _ = Loading.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        Loading.Close();
                    }));
                }
                


            }
            public static void Finished()
            {
                try
                {

                    _ = Loading.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        Loading.Close();
                    }));


                }
                catch (Exception)
                {


                }

            }
        }
    }
}
