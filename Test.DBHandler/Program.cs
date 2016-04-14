using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Test.DBHandler.Properties;
using UC.Platform.Data;

namespace Test.DBHandler
{
    class Program
    {
        private static string sqlAnnualAssignmentTemplat = "select " +
                                            "distinct t0.ASSIGNMENT_ID as DEF_ID," +
                                            "ifnull(t1.ID,'') as ID," +
                                            "ifnull(t1.NAME,'') as NAME," +
                                            "ifnull(t1.DESCRIPTION,'') as DESCRIPTION," +
                                            "ifnull(t1.ASSIGNMENT_YEAR, {0}) as YEAR," +
                                            "ifnull(t1.ASSIGNMENT_MONTH, {1}) as MONTH," +
                                            "ifnull(t1.TARGET, 0) as TARGET," +
                                            "ifnull(t1.CREATE_TIME, current_date()) as CREATE_TIME," +
                                            "ifnull(t1.VERSION_ID, t2.VERSION_ID) as VERSION_ID," +
                                            "ifnull(t1.EXEC_STATE, 0) as STATE," +
                                            "ifnull(t1.CREATOR_ID, 'nobody') as CREATOR," +
                                            "t2.NAME as DEF_NAME," +
                                            "cast(t3.VALUE as decimal) as RATE " +
                                            "from t_position_assignments t0 " +
                                            "left join t_annual_assignment t1 on t1.ASSIGNMENT_ID=t0.ASSIGNMENT_ID and t1.VERSION_ID=t1.VERSION_ID and t1.ASSIGNMENT_YEAR={0} and t1.ASSIGNMENT_MONTH={1} " +
                                            "inner join t_assignment_define t2 on t0.ASSIGNMENT_ID=t2.ID " +
                                            "left join t_settings t3 on cast(substr(t3.NAME, -2) as unsigned)= {1} " +
                                            "where " +
                                            "t0.ENABLED=true " +
                                            "and t2.TYPE = '1' " +
                                            "and t3.NAME like 'assignment.schedule%'";

        private static string getSqlAnnualAssignmentOneMonth(int year, int month)
        {
            //string sqlFormat = "select * from ({0}) t_all";
            return string.Format(sqlAnnualAssignmentTemplat, year, month);
        }

        private static string getAnnualAssignmentSql(string id, int year)
        {
            string sql = "";
            for (int i = 0; i < 12; i++)
            {
                sql += "(" + getSqlAnnualAssignmentOneMonth(year, i + 1) + ")";
                if (i < 11)
                {
                    sql += " union all ";
                }
            }
            return string.IsNullOrEmpty(id) ? string.Format("select * from ({0}) t_all", sql) :
                string.Format("select * from ({0}) t_all where t_all.DEF_ID='{1}'", sql, id);
        }

        static void Main(string[] args)
        {
            DBHandlerEx.RegisterDBDefaultType("MySql.Data.MySqlClient", Settings.Default.conn);

            DataSet dataSet=new DataSet();
            string sql = getAnnualAssignmentSql(null, 2016);
            if (DBHandlerEx.FillNoNameOnce(dataSet, sql) > 0)
            {
                Console.WriteLine("table count： {0}", dataSet.Tables.Count);
                if (dataSet.Tables.Count <= 0)
                {
                    Console.WriteLine("no data....");
                    return;
                }
                dataSet.Tables[0].Columns.Cast<DataColumn>().ToList().ForEach(col => Console.Write("{0}\t\t", col.ColumnName));
                Console.WriteLine();
                dataSet.Tables[0].Rows.Cast<DataRow>().ToList().ForEach(row => row.Table.Columns.Cast<DataColumn>().ToList().ForEach(col => Console.Write("{0}\t\t", row.IsNull(col)?"null" : row[col])));
            }
        }
    }
}
