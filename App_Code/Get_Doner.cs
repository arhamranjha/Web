using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

public class Get_Doner
{

    public List<ColumnInfo> get(string status, string id, string bloodGroup, string city)
    {
        List<ColumnInfo> lst = new List<ColumnInfo>();
        string ConnString;
        ConnString = ColumnInfo.connection;
        SqlConnection conn = new SqlConnection(ConnString);

        SqlCommand newCom = conn.CreateCommand();
        newCom.CommandType = CommandType.StoredProcedure;
        newCom.CommandText = "TBL_DONER_INFORMATION_SELECT_APP";
        newCom.Parameters.AddWithValue("@status", status);
        newCom.Parameters.AddWithValue("@id", id);
        newCom.Parameters.AddWithValue("@Blood_Group", bloodGroup);
        newCom.Parameters.AddWithValue("@City", city);
        conn.Open();
        SqlDataReader sdr = newCom.ExecuteReader();
        if (sdr.HasRows)
        {

            while (sdr.Read())
            {
                ColumnInfo temp = new ColumnInfo();
                temp.StringColumn1 = sdr["ID"].ToString();
                temp.StringColumn2 = sdr["NAME"].ToString();
                temp.StringColumn3 = sdr["ADDRESS"].ToString();
                temp.StringColumn4 = sdr["MOBILE"].ToString();
                temp.StringColumn5 = sdr["CITY_NAME"].ToString();
                temp.StringColumn6 = sdr["EMAIL"].ToString();
                temp.StringColumn7 = sdr["Donation_Date"].ToString();
                temp.StringColumn8 = sdr["REMARKS"].ToString();
                temp.StringColumn9 = sdr["Size_Name"].ToString();

                lst.Add(temp);
            }


        }
        conn.Close();

        return lst;

    }


}