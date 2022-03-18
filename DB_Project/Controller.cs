using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DB_Project
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
        }


        public void createAccount(string ID, string username, string password)
        {
            string query = $"INSERT INTO User_Accounts(Username, Password, User_type, Res_Owner_ID) " +
                            $"Values ('{username}','{password}','ResidenceOwner', '{ID}'); ";

            dbMan.ExecuteNonQuery(query);
        }

        public void AddEmp(string ID, string username, string password)
        {
            string query = $"INSERT INTO User_Accounts(Username, Password, User_type, Emp_ID) " +
                            $"Values ('{username}','{password}','Employee', '{ID}'); ";

            dbMan.ExecuteNonQuery(query);
        }

        public DataTable getResidence_ID(string ID)
        {
            string query = $"SELECT * FROM Residence_Owner WHERE Owner_ID= '{ID}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getEmp(string ID)
        {
            string query = $"SELECT * FROM Employees WHERE Employee_ID= '{ID}'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable getUsername(string username)
        {
            string query = $"SELECT * FROM User_Accounts WHERE Username= '{username}'";
            return dbMan.ExecuteReader(query);
        }

        public void ClearAppointment(int Dep, string ResID)
        {
            string query = $"DELETE FROM Appointments WHERE D#= {Dep} AND Residence_ID= '{ResID}'";

            dbMan.ExecuteNonQuery(query);
        }

        public string Get_Res_Owner_ID(string Uname, string Pass)
        {
            string query = $"SELECT Res_Owner_ID FROM User_Accounts WHERE Username= '{Uname}' AND Password= '{Pass}';";
            string id = (string)dbMan.ExecuteScalar(query);
            return id;
        }

        public int GetDnum(string ID)
        {
            string query = $"SELECT D# FROM Employees WHERE Employee_ID= '{ID}';";
            int id = (int)dbMan.ExecuteScalar(query);
            return id;
        }
        public string Get_Emp_ID(string Uname, string Pass)
        {
            string query = $"SELECT Emp_ID FROM User_Accounts WHERE Username= '{Uname}' AND Password= '{Pass}';";
            string id = (string)dbMan.ExecuteScalar(query);
            return id;
        }
        public DataTable GetAccount(string Uname, string Pass)
        {
            string query = $"SELECT * FROM User_Accounts WHERE UserName = '{Uname}' AND Password = '{Pass}';";

            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectDepName()
        {
            string query = "SELECT Dname FROM Departments;";
            return dbMan.ExecuteReader(query);
        }


        public DataTable get_service_type(int Dnum)
        {
            string query = "SELECT Service_type FROM Compound_Services WHERE D#="+ Dnum +";";
            return dbMan.ExecuteReader(query);
        }


        public string SelectDepName_From_ID(int Dep_ID)
        {

            string query = "SELECT Dname FROM Departments WHERE D#="+Dep_ID+";";
            return (string)dbMan.ExecuteScalar(query);
        }




        public DataTable SelectSerName_From_ID(int Ser_ID, int dep_id)
        {

            string query = "SELECT Service_type FROM Compound_Services WHERE S#=" + Ser_ID + "AND D#="+dep_id+";";
            return dbMan.ExecuteReader(query);
        }

        public int SelectServiceID(string service_name, int Dnumber)
        {
            string query = "SELECT S# FROM Compound_Services where Service_type='" +service_name +"'AND D#="+ Dnumber +";";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable SelectDepServices(int Dep_id)
        {
            string query = "SELECT Service_type FROM Compound_Services where D#="+ Dep_id +";";
            return dbMan.ExecuteReader(query);
        }



        public int InsertComplaint(int Residence_ID,int D,string Complaint)
        {
            string query = "INSERT INTO Complaints (Residence_ID,D#,Complaint) " +
                            "Values (" + Residence_ID + "," + D + ",'" + Complaint + "'); ";
            return dbMan.ExecuteNonQuery(query);
        }
       


        public DataTable Get_Subscribed_Departments(int Res_ID)
        {

            string query = "SELECT DISTINCT D# from Subscribed_In WHERE Residence_ID="+ Res_ID+ "; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Subscribed_Services(int Res_ID , int D_num)
        {

            string query = "SELECT  S# from Subscribed_In WHERE Residence_ID=" + Res_ID + "AND D#="+D_num +"; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Subscribed_Services_all( int D_num)
        {

            string query = "SELECT  S#, Residence_ID from Subscribed_In WHERE  D#=" + D_num + "; ";
            return dbMan.ExecuteReader(query);
        }



        public DataTable Get_Appointments_all(int D_num)
        {

            string query = "SELECT  S#, Residence_ID,Appt_date,Appt_time from Appointments WHERE  D#=" + D_num + "; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Get_Visitors_all()
        {

            string query = "SELECT  Residence_ID,B#,St# ,No_of_visitors from Residence WHERE  No_of_visitors!=" +0 + "; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable Get_Emergency_all()
        {

            string query = "SELECT  Residence_ID,B#,St#  from Residence WHERE  Emergency=1 ; ";
            return dbMan.ExecuteReader(query);
        }


        public DataTable Get_Complaints_all(int D_num)
        {

            string query = "SELECT  Residence_ID,Complaint from Complaints WHERE  D#=" + D_num + "; ";
            return dbMan.ExecuteReader(query);
        }





        public DataTable Selectservicetype()
        {
            string query = "SELECT Service_type from Compound_Services; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selectr(int Residence_ID)
        {
            string query = "SELECT B# FROM Residence Where Residence_ID=" + Residence_ID + ";";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectDhash(string Service_type)
        {
            string query = "SELECT D# FROM Compound_Services Where Service_type=" + Service_type + "; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectShash(string Service_type)
        {
            string query = "SELECT S# FROM Compound_Services Where Service_type=" + Service_type + "; ";
            return dbMan.ExecuteReader(query);
        }

        public int Updatevisitors(int Residence_ID, int No_of_visitors)
        {
            string query = "UPDATE Residence SET No_of_visitors='" + No_of_visitors + "' WHERE Residence_ID=" + Residence_ID+ ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Updatepropertyforsale(int Residence_ID, int For_sale)
        {
            string query = "UPDATE Residence SET For_sale=" +For_sale + " WHERE Residence_ID=" + Residence_ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable SelectDnumber(string Dname)
        {
            string query = "SELECT D# FROM Departments Where Dname='" +Dname + "'; ";
            return dbMan.ExecuteReader(query);
        }

        public int Add_subscription(int D_num, int S_num,int Res_id)
        {
            string query ="INSERT INTO Subscribed_In (D#, S#, Residence_ID) Values (" +D_num +","+S_num+",'"+Res_id +"');" ;
            return dbMan.ExecuteNonQuery(query);
        }



        


        public int Add_Appointment(int D_num, int S_num, int Res_id, DateTime Appointment_Date, DateTime Appointment_Time)
        {
            
            string query = "INSERT INTO Appointments (D#, S#, Residence_ID,Appt_date,Appt_time) Values (" + D_num + "," + S_num + "," + Res_id + ",'"+ Appointment_Date.Date +"','"+Appointment_Time.TimeOfDay+"');";
            return dbMan.ExecuteNonQuery(query);
        }



        public DataTable showDoctors()
        {
            string query = $"SELECT * FROM Doctor;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable showPatients()
        {
            string query = $"SELECT * FROM Patient;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable showPres()
        {
            string query = $"SELECT * FROM Prescription;";
            return dbMan.ExecuteReader(query);
        }

        internal int addDoctor(string text1, short v, object selectedItem, string text2)
        {
            throw new NotImplementedException();
        }
        public DataTable Viewforsale()
            
        {
            int x=1;
            string query = "SELECT B#,St#,Type from Residence Where For_sale="+x+";";

            return dbMan.ExecuteReader(query);
        }
        public DataTable Dhash()

        {



            string query1 = "SELECT D# from Compound_Services;";

            return dbMan.ExecuteReader(query1);


        }
        public DataTable SelectDname(int x)

        {
            string query1 = "SELECT Dname from Departments AS D,Compound_Services as C WHERE D.D#=C.D# AND C.D#="+x+";";

            return dbMan.ExecuteReader(query1);


        }

        public DataTable View_Services()

        {
           

            string query = "SELECT S#,Service_type from Compound_Services;";

            return dbMan.ExecuteReader(query);

            
        }

        public int addDoctor(string name, int ID, char gender, string specialty)
        {
            string query = $"INSERT INTO Doctor (First_Name, ID, Gender, Specialty) " +
                            $"Values ('{name}', {ID}, '{gender}', '{specialty}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addPatient(string name, int ID, int age, int mobnum)
        {
            string query = $"INSERT INTO Patient (First_Name, ID, Age, Mobile_Number) " +
                            $"Values ('{name}', {ID}, {age}, {mobnum});";
            return dbMan.ExecuteNonQuery(query);
        }

        public int addPres(int docID, int patID, string med, string date)
        {
            string query = $"INSERT INTO Prescription (Doctor_ID, Patient_ID, Medicine, Appointment_Date) " +
                            $"Values ({docID}, {patID}, '{med}', '{date}');";
            return dbMan.ExecuteNonQuery(query);
        }

        public int Check_Residence_ID(int ID)
        {
            
            string query = "SELECT COUNT(Residence_ID) FROM Residence WHERE Residence_ID='" + ID + "';";
            int x= (int)dbMan.ExecuteScalar(query);

            return x;
        }



        

        public int getdepid(string dname)
        {

            string query = "SELECT D# FROM Departments WHERE Dname='" + dname + "';";
            int x = (int)dbMan.ExecuteScalar(query);

            return x;
        }

        public int getSerid(string sname)
        {

            string query = "SELECT S# FROM Compound_Services WHERE Service_type='" + sname + "';";
            int x = (int)dbMan.ExecuteScalar(query);

            return x;
        }



        //public DataTable showProductInfo(string Custname)
        //{
        //    string query = $"SELECT product.name, price FROM product, wishlist, customer WHERE wishlist.productID = product.ID AND wishlist.customerID = customer.ID AND customer.name='{Custname}';";
        //    return dbMan.ExecuteReader(query);
        //}

        //public DataTable showProductStat()
        //{
        //    string query = $"SELECT type, AVG(price) as avgPrice From product group by type";
        //    return dbMan.ExecuteReader(query);
        //}

        //public DataTable showMostExp()
        //{
        //    string query = $"SELECT customer.ID FROM product, wishlist, customer WHERE price =( SELECT MAX(price) From product ) AND wishlist.productID = product.ID AND wishlist.customerID = customer.ID";
        //    return dbMan.ExecuteReader(query);
        //}

        //public int InsertEmployee(string Fname, string Minit, string Lname, string SSN)
        //{
        //    string query = $"INSERT INTO Employee (Fname, Minit, Lname, SSN) " +
        //                    $"Values ('{Fname}','{Minit}','{Lname}', {SSN});";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public int DeleteDepartment(string Dnumber)
        //{
        //    string query = $"DELETE FROM Department WHERE Dnumber= {Dnumber};";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public int UpdateProject(string Pnumber, string location)
        //{
        //    string query = $"UPDATE Project SET Plocation='{location}' WHERE Pnumber= {Pnumber};";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        //public DataTable SelectAllEmployees(string Dnumber)
        //{
        //    string query = $"SELECT Fname FROM Employee WHERE Dno={Dnumber};";
        //    return dbMan.ExecuteReader(query);
        //}

        //public int CountEmployees(string Pnumber)
        //{
        //    string query = $"SELECT COUNT(Essn) FROM Works_On WHERE Pno={Pnumber}";
        //    return (int)dbMan.ExecuteScalar(query);
        //}

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
