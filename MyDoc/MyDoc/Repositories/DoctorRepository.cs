using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using MyDoc.Models;

namespace MyDoc.Repositories
{
    public class DoctorRepository
    {
        public static Doctor GetDoctor(int id)
        {
            Doctor doctor = null;
            string sql = $"SELECT * FROM Doctors WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                doctor = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return doctor;
        }
        public static List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();
            string sql = "SELECT * FROM Doctors";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Doctor doctor = CreateObject(reader);
                doctors.Add(doctor);
            }
            reader.Close();
            DB.CloseConnection();
            return doctors;
        }
        private static Doctor CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_Lijecnik"].ToString());
            string firstAndLastName = reader["Ime_prezime"].ToString();
            string specialization = reader["Specijalizacija"].ToString();
            string contact = reader["Kontakt"].ToString();
            string location = reader["Lokacija"].ToString();
            string availability = reader["Dostupnost"].ToString();
            var doctor = new Doctor
            {
                Id = id,
                FirstAndLastName = firstAndLastName,
                Specialization = specialization,
                Contact = contact,
                Location = location,
                Availability = availability
            };
            return doctor;
        }
        public static bool DeleteDoctorAttributes(int doctorId)
        {
            string sql = $"DELETE FROM Doctors WHERE ID_Lijecnik = {doctorId}";

            DB.OpenConnection();

            bool success = DB.ExecuteCommand(sql) > 0;

            DB.CloseConnection();

            return success;
        }
        public static List<Doctor> GetDoctorsByLocation(string location)
        {
            List<Doctor> doctors = new List<Doctor>();
            string sql = $"SELECT * FROM Doctors WHERE Lokacija = '{location}'";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Doctor doctor = CreateObject(reader);
                doctors.Add(doctor);
            }
            reader.Close();
            DB.CloseConnection();

            return doctors;
        }
        public static List<Doctor> GetDoctorsByAvailability(string availability)
        {
            List<Doctor> doctors = new List<Doctor>();
            string sql = $"SELECT * FROM Doctors WHERE Dostupnost = '{availability}'";

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Doctor doctor = CreateObject(reader);
                doctors.Add(doctor);
            }
            reader.Close();
            DB.CloseConnection();

            return doctors;
        }
        public static void InsertDoctor(Doctor doctor)
        {
            string sql = $"INSERT INTO Doctors (ID_lijecnik, Ime_prezime, Specijalizacija, Kontakt, Lokacija, Dostupnost) " +
                         $"VALUES ({doctor.Id}, '{doctor.FirstAndLastName}', '{doctor.Specialization}', '{doctor.Contact}', '{doctor.Location}', '{doctor.Availability}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static void UpdateDoctor(Doctor doctor)
        {
            string sql = $"UPDATE Doctors SET ID_lijecnik = {doctor.Id}, Ime_prezime = {doctor.FirstAndLastName}, Specifikacija = {doctor.Specialization}, Kontakt = {doctor.Contact}, Lokacija = {doctor.Location}, Dostupnost = {doctor.Availability} ";

            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
        public static bool IfDoctorIdExists(int doctorId)
        {
            string sql = $"SELECT * FROM Doctors WHERE ID_lijecnik = {doctorId}";

            DB.OpenConnection();

            using (var reader = DB.GetDataReader(sql))
            {
                if (reader.Read())
                {
                    reader.Close();
                    DB.CloseConnection();
                    return true;
                }
                else
                {
                    reader.Close();
                    DB.CloseConnection();
                    return false;
                }
            }

        }

    }
}
