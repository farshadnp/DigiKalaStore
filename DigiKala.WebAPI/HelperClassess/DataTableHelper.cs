using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DigiKala.WebAPI.HelperClassess
{
    public class DataTableHelper
    {
        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            return (from DataRow row in dt.Rows select GetItem<T>(row)).ToList();
        }
        public static T GetItem<T>(DataRow dr)
        {
            var temp = typeof(T);
            var obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (var pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}
