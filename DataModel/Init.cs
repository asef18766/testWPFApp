using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.Data.SqlClient;
using System.Windows;

namespace testingApp.DataModel
{
    /// <summery>
    /// make with singleton, controll the access of db
    /// </summery>
    class Init
    {
        private static Init instance;
        private Init()
        {
            var connStr = new SqlConnectionStringBuilder()
            {
                DataSource = "DESKTOP-J4ABV9F\\SQLEXPRESS",
                InitialCatalog = "tblDentist",
                IntegratedSecurity = true
            }.ConnectionString;
            var datalayer = XpoDefault.GetDataLayer(connStr, AutoCreateOption.DatabaseAndSchema);
            if (datalayer == null)
            {
                MessageBox.Show("db was dead...");
            }
            XpoDefault.DataLayer = datalayer;

        }
        public static Init GetRef()
        {
            if (instance == null)
                instance = new Init();
            return instance;

        }
    }
}
