using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Mid_Term_Nov_18_23.contactClasses
{
    internal class contactClass
    {
        //Getter Setter Properties
        //Acts as Data Carrier in Application


        public int ContactID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }


        static string myconnstring = ConfigurationManager.ConnectionStrings["Mid_Term_Nov_18_23.Properties.Settings.ContactConnectionString"].ConnectionString;

        
        // selecting data from database 

        public DataTable Select()
        {
            SqlConnection con=new SqlConnection(myconnstring);

            DataTable dt = new DataTable();

            try
            {
                string sql = "select *from tbl_Contact";
                SqlCommand com=new SqlCommand(sql, con);

                SqlDataAdapter adapter= new SqlDataAdapter(com);

                con.Open();
                adapter.Fill(dt);

            }catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool Insert(contactClass contact)
        {
            bool isSuccess=false;

            SqlConnection con = new SqlConnection(myconnstring);

            try
            {

                string sql = "Insert Into tbl_contact(firstName,lastName,contactNo,address,gender) values (@firstName,@lastName, @contactNo, @address, @gender)";

                SqlCommand cmd=new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@firstName", contact.FirstName);
                cmd.Parameters.AddWithValue("@lastName", contact.LastName);
                cmd.Parameters.AddWithValue("@contactNo", contact.ContactNo);
                cmd.Parameters.AddWithValue("@address", contact.Address);
                cmd.Parameters.AddWithValue("@gender", contact.Gender);


                con.Open();
                int rows=cmd.ExecuteNonQuery();

                if (rows > 0) { isSuccess=true; }else { isSuccess=false; }  



            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { con.Close(); }

            

            return isSuccess;
        }


        public bool Update(contactClass contact) 
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(myconnstring);

            try
            {

                string sql = "update tbl_contact set firstName=@firstName, lastName=@lastName, contactNo=@contactNo, address=@address,gender=@gender where contactID=@contactID";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@firstName", contact.FirstName);
                cmd.Parameters.AddWithValue("@lastName", contact.LastName);
                cmd.Parameters.AddWithValue("@contactNo", contact.ContactNo);
                cmd.Parameters.AddWithValue("@address", contact.Address);
                cmd.Parameters.AddWithValue("@gender", contact.Gender);

                cmd.Parameters.AddWithValue("@contactID", contact.ContactID);


                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) { isSuccess = true; } else { isSuccess = false; }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }


        public bool Delete(contactClass contact)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(myconnstring);

            try
            {

                string sql = "delete from tbl_contact where contactID=@contactID";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@contactID", contact.ContactID);


                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0) { isSuccess = true; } else { isSuccess = false; }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

            return isSuccess;

        }
    }
}
