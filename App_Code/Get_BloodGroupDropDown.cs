using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


public class Get_BloodGroupDropDown
{

    public List<ColumnInfo> get()
    {
        List<ColumnInfo> lst = new List<ColumnInfo>();
        string ConnString;
        ConnString = ColumnInfo.connection;
        SqlConnection conn = new SqlConnection(ConnString);

        SqlCommand newCom = conn.CreateCommand();
        newCom.CommandType = CommandType.StoredProcedure;
        newCom.CommandText = "BLOOD_GROUP_DROPDOWN_APP";
        conn.Open();
        SqlDataReader sdr = newCom.ExecuteReader();
        if (sdr.HasRows)
        {
            while (sdr.Read())
            {
                ColumnInfo temp = new ColumnInfo();
                temp.StringColumn1 = sdr["SIZE_ID"].ToString();
                temp.StringColumn2 = sdr["SIZE_NAME"].ToString();
                lst.Add(temp);
            }

        }
        conn.Close();
        return lst;

    }


}