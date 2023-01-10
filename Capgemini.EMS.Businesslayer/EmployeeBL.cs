using System;
using System.Collections.Generic;
using Capgemini.EMS.Entities;
using Capgemini.EMS.Exceptions;
using Capgemini.EMS.DataAcessLayer;

namespace Capgemini.EMS.Businesslayer
{
    public class EmployeeBL
    {
        public static bool Add(Employee emp)
        {
            if (emp.Id<=0)
            {
                throw new EMSExeptions("Employee id should not be less than zero!");

            };
            bool isAdded = EmployeeDAL.Add(emp);
            return isAdded;
        }
        public static List<Employee> GetList()
        {
            var list = EmployeeDAL.GetList();
            return list;
        }
        public static Employee GetById(int id)
        {
            var emp = EmployeeDAL.GetById(id);
            return emp;
        }
        public static bool Update(Employee emp)
        {
            bool isUpdated = EmployeeDAL.Update(emp);
            return isUpdated;
        }

        //deletion

        public static bool Delete(Employee emp)
        {
            bool isDeleted= EmployeeDAL.Delete(emp);
            return isDeleted;
        }
    }
    
}
