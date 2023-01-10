using System;
using System.Collections.Generic;
using System.Linq;
using Capgemini.EMS.Entities;

namespace Capgemini.EMS.DataAcessLayer
{
    public class EmployeeDAL
    {
       
        static List<Employee> list = new List<Employee>();
        public static bool Add(Employee emp)
        {
            list.Add(emp);
            return true;
        }
        public static List<Employee> GetList()
        {
            return list;
        }

        public static Employee GetById(int id) 
        {
            var emp = list.Where(e => e.Id == id).FirstOrDefault();
            return emp;
        }

        public static bool Update(Employee emp)
        {
            var existingEmp = list.Where(e => e.Id == emp.Id).FirstOrDefault();
            existingEmp.Name = emp.Name;
            existingEmp.Dateofjoining = emp.Dateofjoining;

            return true;
        }


        //del
        public static bool Delete(Employee emp) 
        {
            var delete = list.Where(e => e.Id == emp.Id).FirstOrDefault();
            list.Remove(delete);
            return true;
        }
    }
}
