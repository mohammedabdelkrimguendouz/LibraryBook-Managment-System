﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace LibraryBook_DataAccess
{
    static public class clsDataAccessSettings
    {
        static private string GetConnectionString()
        {
            // Set up configuration builder
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Reading a connection string
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            return connectionString;
        }

        public static string ConnectionString = GetConnectionString();
    }
}
