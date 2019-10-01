using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using MyFirstApplication.UWP;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]

namespace MyFirstApplication.UWP
{
    public class SQLiteDb : ISQLiteDB

    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentPath = ApplicationData.Current.LocalFolder.Path;
            var path = Path.Combine(documentPath, "MySQLite.db3");
            return new SQLiteAsyncConnection(path);

        }
    }
}
