using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace labexam
{
    public class Controller
    {
        DBManager dbMan;

        public Controller()
        {
            dbMan = new DBManager();
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
