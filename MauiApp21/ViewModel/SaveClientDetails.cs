using Android.Bluetooth;
using MauiApp21.DataBase;
using MauiApp21.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace MauiApp21.ViewModel
{
    public class SaveClientDetails : INotifyPropertyChanged
    {
       //Access to the DB
       private readonly DBService dbService = new DBService();

       //Observable
       public ObservableCollection<ClientDetails> ClientDetails { get; set; }
            = new ObservableCollection<ClientDetails>();

        //info to save to the db
        private String name;
        private String email;
        private String password;

        //Define them
        public String Name
        {
            get => name;
            set
            {
                name = value; OnPropertyChanged();
            }
        }

       

        public String Email
        {
            get => email;
            set
            {
                email = value; OnPropertyChanged();
            }
        }
        public String Password
        {
            get => password;
            set
            {
                password = value; OnPropertyChanged();
            }
        }

        //BTNS
        public ICommand SaveCommand { get;}
        public ICommand SaveEditCommand { get;}
        public ICommand SignInCommand { get;}
        public ICommand SignupCommand { get;}


        //Constructer
        public SaveClientDetails()
        {
            SaveCommand = new Command(async () => await SaveMethod());
            SaveEditCommand = new Command(async () => await SaveEditMethod());
            SignInCommand = new Command(async () => await SignInMethod());
            SignupCommand = new Command(async () => await SignupMethod());

            //load client details
            LoadClientDetails();


        }

        private async Task SignupMethod()
        {
            throw new NotImplementedException();
        }

        private async Task LoadClientDetails()
        {
           var clientDetails = await dbService.GetClientDetails();
            clientDetails.Clear();
            foreach (var client in clientDetails) 
            {
                clientDetails.Add(client);
            }
        }

        private async Task SignInMethod()
        {
            throw new NotImplementedException();
        }

        private async Task SaveEditMethod()
        {
            throw new NotImplementedException();
        }

        private async Task SaveMethod()
        {
            throw new NotImplementedException();
        }

        protected void OnPropertyChanged([CallerMemberNameAttribute] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }






        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
