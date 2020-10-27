using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace REST_WCF_LINQ_2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentIMP" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentIMP.svc or StudentIMP.svc.cs at the Solution Explorer and start debugging.
    public class StudentIMP : IStudentIMP
    {
        StudentDataDataContext data = new StudentDataDataContext();

        public bool AddStudents(Student st)
        {
            try
            {
                data.Students.InsertOnSubmit(st);
                data.SubmitChanges();
                return true;
            }
            catch { return false; }
            //throw new NotImplementedException();

        }

        public bool DeleteStudents(int id)
        {
            try
            {
                Student st = (from student in data.Students where student.ID == id select student).Single();
                data.Students.DeleteOnSubmit(st);
                return true;
            }
            catch { return false; }
        }

        public Student GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            try
            {
                return (from student in data.Students select student).ToList();

            }catch
            {
                return null;
            }
        }

        public bool UpdateStudents(Student st)
        {
            try
            {
                Student st1 = (from student in data.Students where student.ID == st.ID select student).Single();
                st1.LastName = st.LastName;
                st1.FirstMidName = st.FirstMidName;
                st1.Phone = st.Phone;
                st1.EnrollmentDate = st.EnrollmentDate;
                data.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
