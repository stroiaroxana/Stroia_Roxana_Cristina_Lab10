using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Stroia_Roxana_Cristina_Lab10.Models;
using System.IO;
using Stroia_Roxana_Cristina_Lab10.Data;

namespace Stroia_Roxana_Cristina_Lab10
{
    public partial class App : Application
    {
        static ShoppingListDatabase database; 
        public static ShoppingListDatabase Database 
        {
            get 
            { 
                if (database == null) 
                { 
                    database = new ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ShoppingList.db3")); 
                } 
                return database; 
            } 
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
