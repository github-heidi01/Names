using System.Data;
using System;
using System.Data.Common;

namespace Data
{
    public class Addresses
    {
        public DataTable addresses;

        public Addresses()
        {
            DataTable addressTable = new DataTable("AddressTable");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "id";
            column.ReadOnly = true;
            addressTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "street";
            column.ReadOnly = true;
            addressTable.Columns.Add(column);


            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "house number";
            column.ReadOnly = true;
            addressTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "city";
            column.ReadOnly = true;
            addressTable.Columns.Add(column);

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = addressTable.Columns["id"];
            addressTable.PrimaryKey = PrimaryKeyColumns;


            row = addressTable.NewRow();
            row["id"] = 1;
            row["street"] = "Chestnut Drive";
            row["house number"] = "10";
            row["city"] = "Milbrook";
            addressTable.Rows.Add(row);

            row = addressTable.NewRow();
            row["id"] = 2;
            row["street"] = "Franklin Avenue";
            row["house number"] = "11";
            row["city"] = "Lithgow";
            addressTable.Rows.Add(row);

            row = addressTable.NewRow();
            row["id"] = 3;
            row["street"] = "Candy Lane";
            row["house number"] = "12";
            row["city"] = "Hopewell Junction";
            addressTable.Rows.Add(row);

            addresses = addressTable;
        }
    }
}