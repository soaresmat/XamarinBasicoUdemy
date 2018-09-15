using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SQLite;
using UIKit;
using System.IO;
using Projeto04.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(Database_iOS))]
namespace Projeto04.iOS
{
    public class Database_iOS : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var nomeDB = "projeto04.db3";
            var personalFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var libraryFolder = Path.Combine(personalFolder, "..", "Library");

            var caminhoDB = Path.Combine(libraryFolder, nomeDB);

            return new SQLiteConnection(caminhoDB);
        }
    }
}