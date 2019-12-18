using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using BloodDataSetTableAdapters;
using POSDataSetTableAdapters;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string POS_Get_Catagory()
    {
        POSDataSet pdb = new POSDataSet();
        POS_Get_CatagoryTableAdapter pta = new POS_Get_CatagoryTableAdapter();
        pta.Fill(pdb.POS_Get_Catagory);
        var a = pta.GetData();
        string result = "";
        foreach (var item in a)
        {
            result += item.Catagory_id + "---" + item.Catagory_Desp + "---" + item.Catagory_Details + ";";
        }
        return result;
    }
    [WebMethod]
    public string POS_Get_Employee()
    {
        POSDataSet pdb = new POSDataSet();
        POS_Get_EmployeeTableAdapter pta = new POS_Get_EmployeeTableAdapter();
        pta.Fill(pdb.POS_Get_Employee);
        var a = pta.GetData();
        string result = "";
        foreach (var item in a)
        {
            result += item.Employee_id + "---" + item.FName + "---" + item.LName
                + "---" + item.Status_Desp + "---" + item.Phone_No + "---"
                + item.Rank_Desp + "---" + item.birthdate
                + "---" + item.Email + "---" + item.Password + "---" +
                item.PIN + "---" + item.Joindate
                + "---" + item.Jobdesc + "---" + item.Absents + "---" +
                item.Salary + "---" + item.Net_amount + "---" +
                item.Status_id + "---" + item.Rank_id + ";";
        }
        return result;
    }
    [WebMethod]
    public string POS_Get_Rank()
    {
        POSDataSet pdb = new POSDataSet();
        POS_Get_RankTableAdapter pta = new POS_Get_RankTableAdapter();
        pta.Fill(pdb.POS_Get_Rank);
        var a = pta.GetData();
        string result = "";
        foreach (var item in a)
        {
            result += item.Rank_id + "---" + item.Rank_Desp + ";";
        }
        return result;
    }
    [WebMethod]
    public string POS_Login(string pin, ref int? got)
    {
        POSDataSet pdb = new POSDataSet();
        POS_LoginTableAdapter pta = new POS_LoginTableAdapter();
        pta.Fill(pdb.POS_Login, ref got, pin);
        var a = pta.GetData(ref got, pin);
        string result = "";
        foreach (var item in a)
        {
            result += item.Employee_id + "---" + item.FullName + "---" + item.Status_id
                + "---" + item.Rank_id + "---" + item.Email + "---" + item.Password + "---" +
                item.Absents + "---" + item.PIN + ";";
        }
        return result;
    }
    [WebMethod]
    public string APP_Login(string email, string pass)
    {
        POSDataSet pdb = new POSDataSet();
        APP_LoginTableAdapter pta = new APP_LoginTableAdapter();
        pta.Fill(pdb.APP_Login, email, pass);
        var a = pta.GetData(email, pass);
        string result = "";
        foreach (var item in a)
        {
            result += item.Employee_id + "---" + item.name + "---" + item.Status_id
                + "---" + item.Rank_id + "---" + item.Email + "---" + item.Password + "---" +
                 item.PIN + ";";
        }
        return result;
    }
    [WebMethod]
    public string POS_Report_Sale(string DF, string DT)
    {
        POSDataSet pdb = new POSDataSet(); pdb.EnforceConstraints = false;
        POS_Report_SaleTableAdapter pta = new POS_Report_SaleTableAdapter();
        DateTime dt1 = Convert.ToDateTime(DF);
        DateTime dt2 = Convert.ToDateTime(DT);
        pta.Fill(pdb.POS_Report_Sale, dt1, dt2);
        var a = pta.GetData(dt1, dt2);
        string result = "";
        foreach (var item in a)
        {
            result += item.Order_id + "---" + item.Bill_id + "---" + item.Current_DateTime + "---" + item.Emp_id + "---" + item.Employee_Name
                 + "---" + item.Product_id + "---" + item.Product_Name + "---" + item.Quantity
                 + "---" + item.Optionid + "---" + item.Optionname + "---" + item.OptionQty + "---" + item.Total_Bill + ";";
        }
        return result;
    }
    [WebMethod]
    public string APP_Report_Sale(string DF, string DT)
    {
        POSDataSet pdb = new POSDataSet(); pdb.EnforceConstraints = false;
        APP_Report_SaleTableAdapter pta = new APP_Report_SaleTableAdapter();
        DateTime dt1 = Convert.ToDateTime(DF);
        DateTime dt2 = Convert.ToDateTime(DT);
        pta.Fill(pdb.APP_Report_Sale, dt1, dt2);
        var a = pta.GetData(dt1, dt2);
        string result = "";
        foreach (var item in a)
        {
            result += item.Bill_id + "---" + item.name + "---" + item.Total_Bill + "---" + item.Current_DateTime + ";";
        }
        return result;
    }
    [WebMethod]
    public string POS_Report_Sale_test1(string DF, string DT)
    {
        POSDataSet pdb = new POSDataSet();
        Report_sale_test1TableAdapter pta = new Report_sale_test1TableAdapter();
        DateTime dt1 = Convert.ToDateTime(DF);
        DateTime dt2 = Convert.ToDateTime(DT);
        pta.Fill(pdb.Report_sale_test1, dt1, dt2);
        var a = pta.GetData(dt1, dt2);
        string result = "";
        foreach (var item in a)
        {
            result += item.Order_id + "---" + item.Bill_id + "---" + item.Current_DateTime + "---" + item.FName + " " + item.LName + "---" + item.Total_Bill
                 + "---" + item.Product_id + "---" + item.Product_Name + "---" + item.Quantity + "---" + item.Expr1 + "---" + item.Price + ";";
        }
        return result;
    }
    [WebMethod]
    public string POS_Report_Sale_test2(string DF, string DT)
    {
        POSDataSet pdb = new POSDataSet(); pdb.EnforceConstraints = false;
        Report_sale_test2TableAdapter pta = new Report_sale_test2TableAdapter();
        DateTime dt1 = Convert.ToDateTime(DF);
        DateTime dt2 = Convert.ToDateTime(DT);
        pta.Fill(pdb.Report_sale_test2, dt1, dt2);
        var a = pta.GetData(dt1, dt2);
        string result = "";
        foreach (var item in a)
        {
            result += item.Order_Option_id + "---" + item.Bill_id + "---" + item.Current_DateTime + "---" + item.Product_id
                + "---" + item.Option_id + "---" + item.Option_Desp + "---" + item.Quantity + "---" + item.Option_Price + ";";
        }
        return result;
    }
    [WebMethod]
    public string POS_Most_sold(string DF, string DT)
    {
        POSDataSet pdb = new POSDataSet(); pdb.EnforceConstraints = false;
        most_product_soldTableAdapter pta = new most_product_soldTableAdapter();
        DateTime dt1 = Convert.ToDateTime(DF);
        DateTime dt2 = Convert.ToDateTime(DT);
        pta.Fill(pdb.most_product_sold, dt1, dt2);
        var a = pta.GetData(dt1, dt2);
        string result = "";
        foreach (var item in a)
        {
            result += item.Product_Name + "---" + item.qty_sold + ";";
        }
        return result;
    }
    [WebMethod]
    public string POS_Product_QtySold(string DF, string DT)
    {
        POSDataSet pdb = new POSDataSet(); pdb.EnforceConstraints = false;
        product_quantity_soldTableAdapter pta = new product_quantity_soldTableAdapter();
        DateTime dt1 = Convert.ToDateTime(DF);
        DateTime dt2 = Convert.ToDateTime(DT);
        pta.Fill(pdb.product_quantity_sold, dt1, dt2);
        var a = pta.GetData(dt1, dt2);
        string result = "";
        foreach (var item in a)
        {
            result += item.Product_Name + "---" + item.qty_sold + ";";
        }
        return result;
    }
    [WebMethod]
    public string POS_Employeer_selling(string DF, string DT)
    {
        POSDataSet pdb = new POSDataSet(); pdb.EnforceConstraints = false;
        Employeer_SellingTableAdapter pta = new Employeer_SellingTableAdapter();
        DateTime dt1 = Convert.ToDateTime(DF);
        DateTime dt2 = Convert.ToDateTime(DT);
        pta.Fill(pdb.Employeer_Selling, dt1, dt2);
        var a = pta.GetData(dt1, dt2);
        string result = "";
        foreach (var item in a)
        {
            result += item.name + "---" + item.total + ";";

        }
        return result;
    }
    [WebMethod]
    public string POS_Get_Status()
    {
        POSDataSet pdb = new POSDataSet();
        POS_Get_StatusTableAdapter pta = new POS_Get_StatusTableAdapter();
        pta.Fill(pdb.POS_Get_Status);
        var a = pta.GetData();
        string result = "";
        foreach (var item in a)
        {
            result += item.Status_id + "---" + item.Status_Desp + ";";
        }
        return result;
    }

    [WebMethod]
    public string POS_Get_Products_Options_Rel()
    {
        POSDataSet pdb = new POSDataSet();
        POS_Get_productOptionRelTableAdapter pta = new POS_Get_productOptionRelTableAdapter();
        pta.Fill(pdb.POS_Get_productOptionRel);
        var a = pta.GetData();
        string result = "";
        foreach (var item in a)
        {
            result += item.pro_id + "---" + item.Product_Name + "---" + item.opt_id + "---" + item.Option_Desp + ";";
        }
        return result;
    }
    [WebMethod]
    public string POS_Start_Bill(ref int? got, int _id)
    {
        POSDataSet pdb = new POSDataSet();

        POS_Start_BillTableAdapter pta = new POS_Start_BillTableAdapter();
        var a = pta.GetData(ref got, _id);
        string result = "";
        foreach (var item in a)
        {
            result += item.Bill_id + "---" + item.Current_DateTime + "---" + item.Emp_id + "---" + item.Total_Bill + ";";
        }
        return result;
    }


    [WebMethod]
    public int POS_update_bill(int billid, Decimal total)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Update_Bill(billid, total);
        return a;
    }
    [WebMethod]
    public int POS_delete_bill(int billid)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_delete_Bill(billid);
        return a;
    }
    [WebMethod]
    public string POS_Order_Product(ref int? got, string result)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Ordering_Product(ref got, result);
        return got.ToString();
    }
    [WebMethod]
    public string POS_Order_Options(ref int? got, string result)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Ordering_ProductOptions(ref got, result);
        return got + "";
    }

    [WebMethod]
    public int POS_add_Employee(string FName, string LName, string Status_id, string phone_no, string Rank_id, string birthdate, string Email, string Password, string PIN, string Joindate, string Jobdesc, string Absents, string Salary, string Net_amount)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Add_Employee(FName, LName, int.Parse(Status_id), phone_no, int.Parse(Rank_id), Convert.ToDateTime(birthdate), Email, Password, PIN, Convert.ToDateTime(Joindate), Jobdesc, byte.Parse(Absents), decimal.Parse(Salary), decimal.Parse(Net_amount));
        return a;
    }
    [WebMethod]
    public int POS_update_Employee(int id, string FName, string LName, string Status_id, string phone_no, string Rank_id, string birthdate, string Email, string Password, string PIN, string Joindate, string Jobdesc, string Absents, string Salary, string Net_amount)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Update_Employee(id, FName, LName, int.Parse(Status_id), phone_no, int.Parse(Rank_id), Convert.ToDateTime(birthdate), Email, Password, PIN, Convert.ToDateTime(Joindate), Jobdesc, byte.Parse(Absents), decimal.Parse(Salary), decimal.Parse(Net_amount));
        return a;
    }


    [WebMethod]
    public int POS_add_catagory(string catagoryName, string catagoryDetail)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Add_Catagory(catagoryName, catagoryDetail);
        return a;
    }
    [WebMethod]
    public int POS_update_catagory(int catagoryid, string catagoryName, string catagoryDetail)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Update_Catagory(catagoryid, catagoryName, catagoryDetail);
        return a;
    }
    [WebMethod]
    public int POS_delete_catagory(int catagoryid)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Delete_Catagory(catagoryid);
        return a;
    }
    [WebMethod]
    public int POS_add_Product(string productName, int catagoryid, Decimal price, int statusid, int quantity, string productDesc, decimal buyingPrice)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Add_Product(productName, catagoryid, price, statusid, quantity, productDesc, buyingPrice);
        return a;
    }
    [WebMethod]
    public int POS_Update_Product(int productid, string productName, int catagoryid, Decimal price, int statusid, int quantity, string productDesc, decimal buyingPrice)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Update_Product(productid, productName, catagoryid, price, statusid, quantity, productDesc, buyingPrice);
        return a;
    }
    [WebMethod]
    public int POS_Delete_Product(int productid)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Delete_Product(productid);
        return a;
    }
    [WebMethod]
    public int POS_add_ProductOption(string optionName, Decimal optionPrice, string optionDetails)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Add_ProductOption(optionName, optionPrice, optionDetails);
        return a;
    }
    [WebMethod]
    public int POS_update_ProductOption(int productid, string optionName, Decimal optionPrice, string optionDetails)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Update_ProductOption(productid, optionName, optionPrice, optionDetails);
        return a;
    }
    [WebMethod]
    public int POS_delete_ProductOption(int productid)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Delete_ProductOption(productid);
        return a;
    }

    [WebMethod]
    public int POS_add_ProductOptionRelation(int productid, int optionid)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Add_productOptionRel(productid, optionid);
        return a;
    }
    [WebMethod]
    public int POS_update_ProductOptionRelation(int productid, int Oldoptionid, int Newoptionid)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Update_productOptionRel(productid, Oldoptionid, Newoptionid);
        return a;
    }
    [WebMethod]
    public int POS_delete_ProductOptionRelation(int productid, int optionid)
    {
        POSDataSet pdb = new POSDataSet();
        QueriesTableAdapter pta = new QueriesTableAdapter();
        var a = pta.POS_Delete_productOptionRel(productid, optionid);
        return a;
    }
    [WebMethod]
    public string POS_Get_Product()
    {
        POSDataSet pdb = new POSDataSet();
        POS_Get_ProductTableAdapter pta = new POS_Get_ProductTableAdapter();
        pta.Fill(pdb.POS_Get_Product);
        var a = pta.GetData();
        string result = "";
        foreach (var item in a)
        {
            result += item.Product_id + "---" + item.Product_Name + "---" + item.Catagory_id
                 + "---" + item.Catagory_Desp + "---" + item.Price + "---" + item.Status_id
                 + "---" + item.Status_Desp + "---" + item.Quantity_rem + "---" + item.Product_desc
                 + "---" + item.buying_price + "---" + item.profit + ";";
        }
        return result;
    }

    [WebMethod]
    public string POS_Get_ProductOptions()
    {
        POSDataSet pdb = new POSDataSet();
        POS_Get_ProductOptionsTableAdapter pta = new POS_Get_ProductOptionsTableAdapter();
        pta.Fill(pdb.POS_Get_ProductOptions);
        var a = pta.GetData();
        string result = "";
        foreach (var item in a)
        {
            result += item.Option_id + "---" + item.Option_Desp + "---" + item.Option_Price + "---" + item.Option_Detail + ";";
        }
        return result;
    }


    [WebMethod]
    public string POS_Sale_Order()
    {
        POSDataSet pdb = new POSDataSet();
        POS_Sale_OrderTableAdapter pta = new POS_Sale_OrderTableAdapter();
        var a = pta.GetData();
        string result = "";
        foreach (var item in a)
        {
            result += item.pro_id + "---" + item.opt_id + "---" + item.Option_Desp
                + "---" + item.Option_Detail + "---" + item.Option_Price + ";";
        }
        return result;
    }





    //[WebMethod]
    //public BloodDataSet.TBL_DONER_INFORMATIONDataTable DataSet()
    //{
    //    BloodDataSet bdb = new BloodDataSet();
    //    TBL_DONER_INFORMATIONTableAdapter ta = new TBL_DONER_INFORMATIONTableAdapter();
    //    ta.Fill(bdb.TBL_DONER_INFORMATION);
    //    return ta.GetData();
    //}
    //[WebMethod]
    //public BloodDataSet.CITY_DROP_DOWN_APPDataTable DataSetStore()
    //{
    //    BloodDataSet bdb = new BloodDataSet();
    //    CITY_DROP_DOWN_APPTableAdapter ta = new CITY_DROP_DOWN_APPTableAdapter();
    //    ta.Fill(bdb.CITY_DROP_DOWN_APP);
    //    return ta.GetData();
    //}


    //[WebMethod]
    //public string GetDonner(string status, string id, string bloodGroup, string city)
    //{
    //    List<ColumnInfo> lstRecovery = new List<ColumnInfo>();
    //    Get_Doner rh = new Get_Doner();
    //    lstRecovery = rh.get(status, id, bloodGroup, city);

    //    return ConvertDonerToList(lstRecovery);
    //}
    //[WebMethod]
    //public string BloodGroupDropDown()
    //{
    //    List<ColumnInfo> lstRecovery = new List<ColumnInfo>();
    //    Get_BloodGroupDropDown rh = new Get_BloodGroupDropDown();
    //    lstRecovery = rh.get();

    //    return ConvertBloodGroupDropDownToList(lstRecovery);
    //}
    //[WebMethod]
    //public string CityDropDown()
    //{
    //    List<ColumnInfo> lstRecovery = new List<ColumnInfo>();
    //    Get_CityDropDown rh = new Get_CityDropDown();
    //    lstRecovery = rh.get();

    //    return ConvertCityDropDownToList(lstRecovery);
    //}
    //[WebMethod]
    //public string RegisterDonner(string status, string id, string name, string address, string mobile, string country, string state, string city, string email, string bloodGroup, string donationDate, string remark, string date)
    //{
    //    DateTime dt1 = Convert.ToDateTime(donationDate);
    //    DateTime dt2 = Convert.ToDateTime(date);
    //    List<ColumnInfo> lstRecovery = new List<ColumnInfo>();
    //    Insert_RegisterDoner rh = new Insert_RegisterDoner();
    //    lstRecovery = rh.get(status, id, name, mobile, address, country, state, city, email, bloodGroup, dt1.Date, remark, dt2.Date);
    //    return "Donner Added";
    //}





    //////////////////////////////////////////////////////////////////////////////////////////////////////
    //string ConvertCityDropDownToList(List<ColumnInfo> lst)
    //{
    //    string ret = "";
    //    foreach (var item in lst)
    //    {
    //        ret += item.StringColumn1 + "---" + item.StringColumn2 + "---" + item.StringColumn3 + ";";
    //    }
    //    return ret;
    //}
    //string ConvertDonerToList(List<ColumnInfo> lst)
    //{
    //    string ret = "";
    //    foreach (var item in lst)
    //    {
    //        ret += item.StringColumn1 + "---" + item.StringColumn2 + "---" + item.StringColumn3 + "---" + item.StringColumn4 + "---" + item.StringColumn5 + "---" + item.StringColumn6 + "---" + item.StringColumn7 + "---" + item.StringColumn8 + "---" + item.StringColumn9 + ";";
    //    }

    //    return ret;
    //}

    //string ConvertBloodGroupDropDownToList(List<ColumnInfo> lst)
    //{
    //    string ret = "";
    //    foreach (var item in lst)
    //    {
    //        ret += item.StringColumn1 + "---" + item.StringColumn2 + ";";
    //    }

    //    return ret;
    //}





}