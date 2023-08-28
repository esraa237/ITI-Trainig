using Microsoft.EntityFrameworkCore;
using Third_version.Migrations;
using Third_version.Models;

namespace Third_version.BLL
{
    public class StudentBLL:IStudent
    {
        ITIContext dp = new ITIContext();
        public List<Student> GetAll()
        {
            return dp.Students.Include(x=>x.Department).ToList();
        }
        public Student GetById(int id)
        {
            return dp.Students.Include(x => x.Department).FirstOrDefault(a => a.Id == id);
        }
        public Student Update(Student std)
        {
            dp.Students.Update(std);
            dp.SaveChanges();
            return std;
        }
        public Student Add(Student std)
        {
            dp.Students.Add(std);
            dp.SaveChanges();
            return std;
        }
        public void Delete(int id)
        {
            Student student = dp.Students.SingleOrDefault(a => a.Id == id);
            dp.Students.Remove(student);
            dp.SaveChanges();
        }
    }
}
