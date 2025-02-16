﻿using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    internal class TableDAO
    {
        // singleton
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) { instance = new TableDAO(); } return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int tableWidth = 100;
        public static int tableHeight = 100;

        private TableDAO() { }

        public List<Table> loadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows) 
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }


    }
}
