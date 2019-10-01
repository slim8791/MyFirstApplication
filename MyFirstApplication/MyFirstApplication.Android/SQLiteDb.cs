using System;
using System.IO;
using MyFirstApplication;
using MyFirstApplication.Droid;
using SQLite;
using Xamarin.Forms;
[assembly: Dependency(typeof(SLiteDb))]

namespace MyFirstApplication.Droid
{
    public class SLiteDb : ISQLiteDB
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}