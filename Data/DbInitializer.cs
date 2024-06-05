using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace ErenSevindikFlightApp.Data
{
    public static class DbInitializer
    {
       
        private static string connectionString = "Data Source=..\\..\\Data\\ErenSevindikFlightAppDb.db;Version=3;";

        public static void InitializeDatabase()
        {
            if (!File.Exists("..\\..\\Data\\ErenSevindikFlightAppDb.db"))
            {
                SQLiteConnection.CreateFile("..\\..\\Data\\ErenSevindikFlightAppDb.db");
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string createUcakTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Ucak(
                        id INTEGER PRIMARY KEY NOT NULL,
                        Model TEXT NOT NULL,
                        Marka TEXT NOT NULL,
                        SeriNo INTEGER NOT NULL,
                        KoltukKapasite INTEGER NOT NULL
                    );";

                    string insertUcakQuery = @"
                    INSERT INTO Ucak (Model, Marka, SeriNo, KoltukKapasite) VALUES ('Boeing', 'Embraer', 48, 120);
                    INSERT INTO Ucak (Model, Marka, SeriNo, KoltukKapasite) VALUES ('Clipper', 'Airbus', 67, 120);";



                    string createLokasyonTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Lokasyon(
                        id INTEGER PRIMARY KEY NOT NULL,
                        Ulke TEXT NOT NULL,
                        Sehir TEXT NOT NULL,
                        Havaalani TEXT NOT NULL,
                        Tarih TEXT NOT NULL,
                        Saat TEXT NOT NULL


                    );";


                    string insertLokasyonQuery = @"
                    INSERT INTO Lokasyon (Ulke, Sehir, Havaalani,Tarih, Saat) VALUES ('Türkiye', 'Izmir', 'İzmir Adnan Menderes Havalimanı', '11.02.2000', '10:00');
                    INSERT INTO Lokasyon (Ulke, Sehir, Havaalani, Tarih, Saat) VALUES ('Amerika', 'San Francisco', 'San Francisco Uluslararası Havaalanı ', '22.05.2004', '17:02');
                    INSERT INTO Lokasyon (Ulke, Sehir, Havaalani, Tarih, Saat) VALUES ('Türkiye', 'Antalya', 'Antalya Havalimanı ', '27.05.2024', '06:34');";


                    string createKoltukTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Koltuk(
                        id INTEGER PRIMARY KEY NOT NULL,
                        KoltukKapasitesi INTEGER NOT NULL  
                    );";

                    string insertKoltukQuery = @"
                   INSERT INTO Koltuk (KoltukKapasitesi) VALUES (50);
                   INSERT INTO Koltuk (KoltukKapasitesi) VALUES (50);
                   INSERT INTO Koltuk (KoltukKapasitesi) VALUES (50);
                   INSERT INTO Koltuk (KoltukKapasitesi) VALUES (50);";


                    string createRezervasyonTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Rezervasyon(
                        id INTEGER PRIMARY KEY NOT NULL,
                        KoltukNo TEXT NOT NULL,
                        LokasyonId INTEGER NOT NULL,
                        FOREIGN KEY (LokasyonId) REFERENCES Lokasyon(id)
                    );";

                    string insertRezervasyonQuery = @"
                   INSERT INTO Rezervasyon (KoltukNo, LokasyonId) VALUES ('a2', 1);
                   INSERT INTO Rezervasyon (KoltukNo, LokasyonId) VALUES ('b4', 1);
                   INSERT INTO Rezervasyon (KoltukNo, LokasyonId) VALUES ('c3', 1);
                   INSERT INTO Rezervasyon (KoltukNo, LokasyonId) VALUES ('d2', 1);";
                  



                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createUcakTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertUcakQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = createLokasyonTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertLokasyonQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = createKoltukTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertKoltukQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = createRezervasyonTableQuery;
                        command.ExecuteNonQuery();

                        command.CommandText = insertRezervasyonQuery;
                        command.ExecuteNonQuery();

                    }

                }
            }
        }
    }
    }

