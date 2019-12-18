using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

public class Insert_RegisterDoner
{
    public List<ColumnInfo> get(string status, string id, string name, string address, string mobile, string country, string state, string city, string email, string bloodGroup, DateTime dt1, string remark, DateTime dt2)
    {
        List<ColumnInfo> lst = new List<ColumnInfo>();
        string ConnString;
        ConnString = ColumnInfo.connection;
        SqlConnection conn = new SqlConnection(ConnString);

        SqlCommand newCom = conn.CreateCommand();
        newCom.CommandType = CommandType.StoredProcedure;
        newCom.CommandText = "TBL_DONER_INFORMATION_INSERT";
        newCom.Parameters.AddWithValue("@status", status);
        newCom.Parameters.AddWithValue("@id", id);
        newCom.Parameters.AddWithValue("@NAME", name);
        newCom.Parameters.AddWithValue("@ADDRESS", address);
        newCom.Parameters.AddWithValue("@MOBILE", mobile);
        newCom.Parameters.AddWithValue("@COUNTRY", country);
        newCom.Parameters.AddWithValue("@STATE", state);
        newCom.Parameters.AddWithValue("@City", city);
        newCom.Parameters.AddWithValue("@EMAIL", email);
        newCom.Parameters.AddWithValue("@BLOOD_GROUP", bloodGroup);
        newCom.Parameters.AddWithValue("@DONATION_DATE", dt1.Date);
        newCom.Parameters.AddWithValue("@REMARKS", remark);
        newCom.Parameters.AddWithValue("@date", dt2.Date);
        conn.Open();
        SqlDataReader sdr = newCom.ExecuteReader();
        conn.Close();
        return lst;

    }
}