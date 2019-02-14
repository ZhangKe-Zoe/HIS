using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Register
{
    public class DAL
    {
        public SqlCommand mycmd = new SqlCommand();
        public string mysql;
        static string mystr = @"Data Source=MAC\SQLEXPRESS;Initial Catalog=register;Integrated Security=True";
        public SqlConnection myconn = new SqlConnection(mystr);
        public DataSet dataset = new DataSet();

        //connect to database 
        public bool ConnDB()
        {
            try
            {
                myconn.Open();

            }
            catch (Exception)
            {

                throw;
            }

            if (myconn.State == System.Data.ConnectionState.Open)
                return true;
            else
                return false;


        }

        //try catch 
        public void TC()
        {
            try
            {
                myconn.Open();
                mycmd.ExecuteNonQuery();
                myconn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }
        }

        //insert data 
        public void insert(Register re)
        {
            this.mysql = "insert into register (zlk,mz,name,age,sr,cid,sex,nat,tel,regs,chas,dep,doc,rdate,rtime,pay) " +
            "values('" + re.zlk + "','" + re.mz + "','" + re.name + "','" + re.age + "','"+ re.sr +"','"+ re.cid + "'" +
            ",'" + re.sex + "','" + re.nat + "','" +  re.tel + "','" + re.regs + "','" + re.chas + "'," +
            "'" + re.dep + "','" + re.doc + "','" + re.rdate + "','" + re.rtime + "','" + re.pay + "') ";
            this.mycmd.CommandText = this.mysql;
            this.mycmd.Connection = this.myconn;
            this.mycmd.ExecuteNonQuery();
        }

        public void insertERM(Register re)
        {
            this.mysql = "insert into EMR (zlk,mz,name,age,sr,cid,sex,nat,chas,dep,doc,rdate,rtime,zs,xbs,jws) " +
            "values('" + re.zlk + "','" + re.mz + "','" + re.name + "','" + re.age + "','" + re.sr + "','" + re.cid + "'" +
            ",'" + re.sex + "','" + re.nat + "','" + re.chas + "','" + re.dep + "','" + re.doc + "','" + re.rdate + "','" + re.rtime + "'," +
            "'" + re.zs + "','"+re.xbs+"','"+re.jws+"') ";
            this.mycmd.CommandText = this.mysql;
            this.mycmd.Connection = this.myconn;
            this.mycmd.ExecuteNonQuery();
        }

        public void insertZD(Register re)
        {
            this.mysql = "insert into zd (zlk,name,sex,age,zds,zdresult,zdid,fbdate,zddate,zdmain,zdft,zdconfirm) " +
            "values('" + re.zlk + "','" + re.name + "','" + re.sex + "','" + re.age + "','" + re.zds + "','" + re.zdresult + "','" + re.zdid + "'" +
            ",'" + re.fbdate + "','" + re.zddate + "','" + re.zdmain + "','" + re.zdft + "','" + re.zdconfirm + "') ";
            this.mycmd.CommandText = this.mysql;
            this.mycmd.Connection = this.myconn;
            this.mycmd.ExecuteNonQuery();
        }

        //delete data 
        public void delect(string mz)
        {


            this.mysql = "delete from register where mz ='" + mz + "'";
            this.mycmd.CommandText = this.mysql;
            this.mycmd.Connection = this.myconn;
            this.mycmd.ExecuteNonQuery();


        }
        //GridviewJZ
        public void GridviewJZ(string doc,string rtime,string rdate)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From register where doc ='"+doc+"'AND rtime = '"+rtime+"'AND rdate = '"+rdate+"' " , myconn);
            sda.Fill(dataset, "register");
        }
       // GridviewZD
        public void GridviewZD(string zlk)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From zd where zlk ='" + zlk + " '", myconn);
            sda.Fill(dataset, "zd");
        }
        // ComboxZD
        public void ComboxZD(string key)
        {
            string s = "%%" + key + "%%";
            string sql = string.Format("Select * From icd10 where ICD10名称 like'{0}'", s);
            SqlDataAdapter sda = new SqlDataAdapter(sql, myconn);
            sda.Fill(dataset, "zd");
        }
        //show data 
        public void show(string mz, string column)
        {
            this.mysql = " select " + column + " from register where mz = '" + mz + "'";
            this.mycmd.CommandText = this.mysql;
            this.mycmd.Connection = this.myconn;
        }
        //show ZLKdata 
        public void showzlk(string zlk, string column)
        {
            this.mysql = " select " + column + " from zlk where zlk = '" + zlk + "'";
            this.mycmd.CommandText = this.mysql;
            this.mycmd.Connection = this.myconn;
        }
        //show EMRdata
        public void showEMR(string mz, string column)
        {
            this.mysql = " select " + column + " from EMR where mz = '" + mz + "'";
            this.mycmd.CommandText = this.mysql;
            this.mycmd.Connection = this.myconn;
        }
        //show ZDdata
        public void showZD(string zlk, string column)
        {
            this.mysql = " select " + column + " from zd where zlk = '" + zlk + "'";
            this.mycmd.CommandText = this.mysql;
            this.mycmd.Connection = this.myconn;
        }
        //show ICD10
        public void showICD10(string result, string column)
        {
            this.mysql = " select " + column + " from icd10 where ICD10名称 = '" + result + "'";
            this.mycmd.CommandText = this.mysql;
            this.mycmd.Connection = this.myconn;
        }


    }
}
