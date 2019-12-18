using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
public class Get_CityDropDown
{

    public List<ColumnInfo> get()
    {
        List<ColumnInfo> lst = new List<ColumnInfo>();
        string ConnString;
        ConnString = ColumnInfo.connection;
        SqlConnection conn = new SqlConnection(ConnString);

        SqlCommand newCom = conn.CreateCommand();
        newCom.CommandType = CommandType.StoredProcedure;
        newCom.CommandText = "CITY_DROP_DOWN_APP";
        conn.Open();
        SqlDataReader sdr = newCom.ExecuteReader();
        if (sdr.HasRows)
        {
            while (sdr.Read())
            {
                ColumnInfo temp = new ColumnInfo();
                temp.StringColumn1 = sdr["STATE_CODE"].ToString();
                temp.StringColumn2 = sdr["CITY_CODE"].ToString();
                temp.StringColumn3 = sdr["CITY_NAME"].ToString();
                lst.Add(temp);
            }

        }
        conn.Close();
        return lst;

    }


}