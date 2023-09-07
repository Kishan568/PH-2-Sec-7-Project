using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Project_3.Models
{
    public class StudentMarks
    {
        string connectionString = "data source=LAPTOP-HLM075I8;initial catalog=SSchool;integrated security=True;MultipleActiveResultSets=True;TrustServerCertificate=true;";

        public IEnumerable<Student> GetAllStudents()
        {
            List<Student> lstStudents = new List<Student>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Students", con);
                cmd.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Student student = new Student();

                    student.Id = Convert.ToInt32(rdr["Id"]);
                    student.StudentsName = rdr["StudentsName"].ToString();
                    student.StudentClass = Convert.ToInt32(rdr["StudentClass"]);
                    student.StudentsObtainMarks = Convert.ToInt32(rdr["StudentsObtainMarks"]); ;
                    lstStudents.Add(student);
                }
                con.Close();
            }
            return lstStudents;
        }
    }
}
