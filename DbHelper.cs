using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.IO;
using System.Xml;

namespace Starbuko
{
    public static class DbHelper
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = GetConnectionString();
            return new MySqlConnection(connectionString);
        }

        private static string GetConnectionString()
        {
            string localConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\App.config.local");
            localConfigPath = Path.GetFullPath(localConfigPath);

            if (File.Exists(localConfigPath))
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(localConfigPath);

                XmlNode node = xml.SelectSingleNode("//connectionStrings/add[@name='MyDb']");

                if (node != null && node.Attributes["connectionString"] != null)
                {
                    return node.Attributes["connectionString"].Value;
                }
            }

            return ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;
        }
    }
}