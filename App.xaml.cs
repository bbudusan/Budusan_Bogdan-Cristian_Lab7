using System;
using Budusan_Bogdan_Cristian_Lab7;
using System.IO;
using Budusan_Bogdan_Cristian_Lab7.Data;

namespace Budusan_Bogdan_Cristian_Lab7;

public partial class App : Application
{
    static ShoppingListDatabase database;
    public static ShoppingListDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new
               ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
               LocalApplicationData), "ShoppingList.db3"));
            }
            return database;
        }
    }
    public App()
	{
		InitializeComponent();
       // Xamarin.FormsMaps.Init("bingmapkey");
       // Windows.Services.Maps.MapService.ServiceToken = "bingmapkey";
        MainPage = new AppShell();
	}
}
