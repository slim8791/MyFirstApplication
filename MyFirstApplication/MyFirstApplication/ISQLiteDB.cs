using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MyFirstApplication
{
    public interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection();
    }
}
