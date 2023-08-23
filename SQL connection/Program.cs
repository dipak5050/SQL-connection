using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace SQL_connection
{
    class customer
    {
           //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
           // SqlCommand cmd = new SqlCommand();
   
        
        public void insertcustomer()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query = "insert into customer values('pappu',GETDATE())";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            con.Close();

            //string QueryInsertCustomer = "managecustomer";
            //con.Open();
            //cmd = new SqlCommand(QueryInsertCustomer, con);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@CustomerId ", System.Data.SqlDbType.Int).Value = 0;
            //cmd.Parameters.Add("@CustomerName", System.Data.SqlDbType.VarChar).Value = "Added By SP";
            //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "i";
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();

        }
        public void selectcustomer()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            string query = "select top 1 Cumstomer from customer";
            cmd= new SqlCommand(query,con);
            con.Open();
            string CustomerName = Convert.ToString(cmd.ExecuteScalar());
            Console.WriteLine(CustomerName);
            con.Close();

            //string QuerySelectCustomer = "managecustomer";
            //con.Open();
            //cmd = new SqlCommand(QuerySelectCustomer, con);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@CustomerId ", System.Data.SqlDbType.Int).Value = 0;
            //cmd.Parameters.Add("@CustomerName", System.Data.SqlDbType.VarChar).Value = "Added By SP";
            //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "s";
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();

        }
        public void updatecustomer()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            string UpdateQuery = "update customer set Cumstomer='champak' where Cid=5";
            con.Open();
            cmd=new SqlCommand(UpdateQuery, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();

            //string QueryUpdateCustomer = "managecustomer";
            //con.Open();
            //cmd = new SqlCommand(QueryUpdateCustomer, con);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@CustomerId ", System.Data.SqlDbType.Int).Value = 5;
            //cmd.Parameters.Add("@CustomerName", System.Data.SqlDbType.VarChar).Value = "Added By SP";
            //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "u";
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();
        }
        public void deletecutomer()
        {
            SqlConnection con= new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            string DeleteQuery= "delete from customer where Cid>=7";
            con.Open();
            cmd = new SqlCommand(DeleteQuery, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();

            //string QueryInsertCustomer = "managecustomer";
            //con.Open();
            //cmd = new SqlCommand(QueryDeleteCustomer, con);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@CustomerId ", System.Data.SqlDbType.Int).Value = 7;
            //cmd.Parameters.Add("@CustomerName", System.Data.SqlDbType.VarChar).Value = "Added By SP";
            //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "d";
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();
        }
    }
    class ProductType
    {
        public void InsertProductType()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();

            string QueryInsertProductType = "productTypepro";
            con.Open();
            cmd =new SqlCommand(QueryInsertProductType, con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@ProductTypeName",System.Data.SqlDbType.VarChar).Value= "Added By SP";
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value="i";
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //SqlCommand cmd = new SqlCommand();
            //string insertQuery = "insert into ProductType values('card',GETDATE());";
            //con.Open();
            //cmd = new SqlCommand(DeleteQuery, con);
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();


        }
        public void selectProductType()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();

            string QueryslectproductType = "select * from ProductType";
            con.Open();
            cmd = new SqlCommand(QueryslectproductType, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();

            // string Queryslectproduct = "productTypepro";
            // con.Open();

            // cmd = new SqlCommand(Queryslectproduct, con);
            ////cmd.CommandType = System.Data.CommandType.StoredProcedure;
            // cmd.Parameters.Add("@ProductTypeId",System.Data.SqlDbType.Int).Value = 7;
            // cmd.Parameters.Add("@ProductTypeName", System.Data.SqlDbType.VarChar).Value = "Added By SP";
            // cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "s";
            // //cmd.ExecuteNonQuery();
            // cmd.ExecuteNonQuery();
            //// Console.WriteLine(select);
            // con.Close();
        }
        public void UpdateProductType()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();

            
            string UpdateProductType = "productTypepro";
            con.Open();
            cmd = new SqlCommand(UpdateProductType,con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 6;
            cmd.Parameters.Add("@ProductTypeName", System.Data.SqlDbType.VarChar).Value = "hi";
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = 'u';
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //SqlCommand cmd = new SqlCommand();
            // string UpdateProductType = "update ProductType set PType='update' where PTid=6";
            //con.Open();
            //cmd = new SqlCommand(UpdateProductType, con);
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();

        }
        public void DeleteProductType()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string DeleteProductType = "delete from ProductType where PTid>=7";
            SqlCommand cmd = new SqlCommand(DeleteProductType,con);
            con.Open();
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();

            //string DeleteProductType = "productTypepro";
            //con.Open();
            //cmd = new SqlCommand(DeleteProductType, con);
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 6;
            //cmd.Parameters.Add("@ProductTypeName", System.Data.SqlDbType.VarChar).Value = "hi";
            //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = 'd';
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();
        }
    }
    public class ProductName
    {
        public void InsertProductName()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string QueryInsertProductName = "productNamepro";
            SqlCommand cmd = new SqlCommand(QueryInsertProductName, con);
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar).Value = "icecream";
            cmd.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = 2;
            cmd.Parameters.Add("@ProductRS", System.Data.SqlDbType.Float).Value = 12;
            cmd.Parameters.Add("@ProductStock", System.Data.SqlDbType.Int).Value = 50;
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "i";

            cmd.ExecuteNonQuery();
            con.Close();


            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //SqlCommand cmd = new SqlCommand();
            //string InsertQuery = "insert into ProductName values('icecream',2,12,50)";
            //con.Open();
            //cmd = new SqlCommand(InsertQuery, con);
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();
        }
        public void UpdateProductName()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string UpdateProductName = "productNamepro";
            SqlCommand cmd = new SqlCommand(UpdateProductName, con);
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 14;
            cmd.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar).Value = "gulfi";
            cmd.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = 2;
            cmd.Parameters.Add("@ProductRS", System.Data.SqlDbType.Float).Value = 12;
            cmd.Parameters.Add("@ProductStock", System.Data.SqlDbType.Int).Value = 500;
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "u";

            cmd.ExecuteNonQuery();
            con.Close();

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //SqlCommand cmd = new SqlCommand();
            //string UpdateQuery = "update ProductName set PName='gulfi" where pid=31;
            //con.Open();
            //cmd = new SqlCommand(UpdateQuery, con);
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();
        }
        public void deleteProductName()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();
            string DeleteQuery = "delete from ProductName where PNid=23";
            con.Open();
            cmd = new SqlCommand(DeleteQuery, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //string DeleteProductName = "productNamepro";
            //SqlCommand cmd = new SqlCommand(DeleteProductName, con);
            //con.Open();
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 14;
            //cmd.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar).Value = "gulfi";
            //cmd.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = 2;
            //cmd.Parameters.Add("@ProductRS", System.Data.SqlDbType.Float).Value = 12;
            //cmd.Parameters.Add("@ProductStock", System.Data.SqlDbType.Int).Value = 500;
            //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "u";

            //cmd.ExecuteNonQuery();
            //con.Close();

        }
        public void selectProductName()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();

            string QueryslectproductType = "select * from ProductName";
            con.Open();
            cmd = new SqlCommand(QueryslectproductType, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //string SelectProductName = "productNamepro";
            //SqlCommand cmd = new SqlCommand(SelectProductName, con);
            //con.Open();
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 14;
            //cmd.Parameters.Add("@ProductName", System.Data.SqlDbType.VarChar).Value = "gulfi";
            //cmd.Parameters.Add("@ProductID", System.Data.SqlDbType.Int).Value = 2;
            //cmd.Parameters.Add("@ProductRS", System.Data.SqlDbType.Float).Value = 12;
            //cmd.Parameters.Add("@ProductStock", System.Data.SqlDbType.Int).Value = 500;
            //cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "s";

            //cmd.ExecuteNonQuery();
            //con.Close();


        }
    }
    class total
    {
        public void Inserttoal()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string QueryInsertProductName = "total1";
            SqlCommand cmd = new SqlCommand(QueryInsertProductName, con);
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@BillId", System.Data.SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 2;
            cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 12;
            cmd.Parameters.Add("@Quantity", System.Data.SqlDbType.Int).Value = 50;
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "i";

            cmd.ExecuteNonQuery();
            con.Close();

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //SqlCommand cmd = new SqlCommand();
            //string InsertQuery = "insert into total values(1,3,12,5)";
            //con.Open();
            //cmd = new SqlCommand(UpdateQuery, con);
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();
        }
        public void UpdateTotal()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string UpdateTotal = "total1";
            SqlCommand cmd = new SqlCommand(UpdateTotal, con);
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@BillId", System.Data.SqlDbType.Int).Value = 11;
            cmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 4;
            cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 2;
            cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 12;
            cmd.Parameters.Add("@Quantity", System.Data.SqlDbType.Int).Value = 50;
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "u";

            cmd.ExecuteNonQuery();
            con.Close();


            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //SqlCommand cmd = new SqlCommand();
            //string UpdateQuery = "update total set Cid=1 where BillNo=3";
            //con.Open();
            //cmd = new SqlCommand(UpdateQuery, con);
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();
        }
        public void deleteTotal()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultconnection"].ToString());
           
            string DeleteTotalV = "total1";
            SqlCommand cmd = new SqlCommand(DeleteTotalV, con);
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 4;
            cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 2;
            cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 12;
            cmd.Parameters.Add("@Quantity", System.Data.SqlDbType.Int).Value = 50;
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "d";
            cmd.Parameters.Add("@BillId", System.Data.SqlDbType.Int).Value = 20;


            cmd.ExecuteNonQuery();
            con.Close();


            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //SqlCommand cmd = new SqlCommand();
            //string DeleteQuery = "delete from total where BillNo=1";
            //con.Open();
            //cmd = new SqlCommand(DeleteQuery, con);
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();
        }
        public void selectTotal()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            string SelcetTotalV = "total1";
            SqlCommand cmd = new SqlCommand(SelcetTotalV, con);
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@CustomerId", System.Data.SqlDbType.Int).Value = 4;
            cmd.Parameters.Add("@ProductTypeId", System.Data.SqlDbType.Int).Value = 2;
            cmd.Parameters.Add("@ProductNameId", System.Data.SqlDbType.Int).Value = 12;
            cmd.Parameters.Add("@Quantity", System.Data.SqlDbType.Int).Value = 50;
            cmd.Parameters.Add("@OPType", System.Data.SqlDbType.VarChar).Value = "s";
            cmd.Parameters.Add("@BillId", System.Data.SqlDbType.Int).Value = 20;


            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            //SqlCommand cmd = new SqlCommand();
            //string SelectQuery = "select * from total";
            //con.Open();
            //cmd = new SqlCommand(SelectQuery, con);
            //int rowaffected = cmd.ExecuteNonQuery();
            //Console.WriteLine(rowaffected);
            //con.Close();
        }
    }
    class buy
    {
        public void BuyInsert()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();

            string QuerysInsertBuy = "insert into buy values('soda',4,12)";
            con.Open();
            cmd = new SqlCommand(QuerysInsertBuy, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();
        }
        public void BuyUpdate()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();

            string QueryUpdatetBuy = "update  buy set producname='jira' where productid=13";
            con.Open();
            cmd = new SqlCommand(QueryUpdatetBuy, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();
        }
        public void BuyDelete()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();

            string QueryDeleteBuy = "delete  from buy where productid=13";
            con.Open();
            cmd = new SqlCommand(QueryDeleteBuy, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();
        }
        public void BuySelect()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();

            string QueryselectBuy = "select * from buy";
            con.Open();
            cmd = new SqlCommand(QueryselectBuy, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();
        }
    }
    class admin
    {
        public void AdminSelect()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();

            string Queryselectadmin = "select * from admin";
            con.Open();
            cmd = new SqlCommand(Queryselectadmin, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();
        }
        public void AdimnInsert()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();

            string QuerysInsertadmin = "insert into admin values('admin1',50000,GETDATE())";

            con.Open();
            cmd = new SqlCommand(QuerysInsertadmin, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();

        }
        public void AdminUpate()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();

            string QueryUpdatetBuy = "update admin set Gallo=50000 where Adminid=1";
            con.Open();
            cmd = new SqlCommand(QueryUpdatetBuy, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();
        }
        public void AdminDelete()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            SqlCommand cmd = new SqlCommand();

            string QueryDeleteadmin = "delete  from admin where Adminid=4";
            con.Open();
            cmd = new SqlCommand(QueryDeleteadmin, con);
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine(rowaffected);
            con.Close();
        }
    }


        class Program
    {
        static void Main(string[] args)
        {
            customer cms = new customer();
            cms.insertcustomer();
            cms.selectcustomer();
            cms.updatecustomer();
            cms.deletecutomer();

            ProductType pt = new ProductType();
            pt.InsertProductType();
            pt.selectProductType();
            pt.UpdateProductType();
            pt.DeleteProductType();

            ProductName pn = new ProductName();
            pn.InsertProductName();
            pn.UpdateProductName();
            pn.deleteProductName();
            pn.selectProductName();

            total t = new total();
            t.Inserttoal();
            t.UpdateTotal();
           t.deleteTotal();
            t.deleteTotal();


            buy b = new buy();
            b.BuyInsert();
            b.BuyUpdate();
            b.BuyDelete();
            b.BuySelect();

            admin a = new admin();
            a.AdimnInsert();
            a.AdminUpate();
            a.AdminDelete();
            a.AdminSelect();

            Console.ReadKey();

            
        }
    }
}
