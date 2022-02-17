using System;

namespace APIDesign.ReaderWriter
{
    public abstract class ReaderWriterAPIContract
    {
        public abstract DepartmentDto
        CreateDepartment(DepartmentDto department);

        public abstract EmployeeDto CreateEmployee(EmployeeDto employee);

        public abstract EmployeeDto EditEmployee(Employee employee);

        public abstract EmployeeDto GetEmployee(string empId);

        public abstract EmployeeDto GetAllEmployee();
    }

    public class DepartmentDto
    {
        public string deptId;

        public string deptName;
    }

    public abstract class Department
    {
        public abstract void CreateDepartment(DepartmentDto dto);

        public abstract void UpdateDepartment(DepartmentDto dto);
    }

    public class EmployeeDto { }

    public class Employee { }
}
