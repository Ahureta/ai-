using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 编程题3
{
    internal class Employee
    {
        //私有字段：员工编号（int EmpId）、员工姓名（string EmpName）、所属部门（string Department）、员
        //工薪资（double Salary）
        //为所有私有字段编写对应的public公开属性（get、set）
        //编写有参构造方法，一次性初始化四个字段数据
        //编写实例方法 ShowEmpInfo()：控制台格式化打印员工所有信息（编号、姓名、部门、薪资）

        private int _empId;
        private string _empName;
        private string _department;
        private double _salary;

        public int EmpId
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public string EmpName
        {
            get { return _empName; }
            set { _empName = value; }
        }
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        public double Salary
        {
            get { return _salary; }
            set 
            {                 
                if (double.TryParse(value.ToString(), out double result))
                {
                    _salary = result;
                }
                else
                {
                    throw new ArgumentException("薪资必须为数字", nameof(value));
                }
                if (value < 0) throw new ArgumentException("薪资不能为负数", nameof(value));
            }
        }
        public Employee(int empId, string empName, string department, double salary)
        {
            _empId = empId;
            _empName = empName;
            _department = department;
            _salary = salary;
        }
        public void ShowEmpInfo()
        {
            Console.WriteLine($"员工编号：{_empId}");
            Console.WriteLine($"员工姓名：{_empName}");
            Console.WriteLine($"所属部门：{_department}");
            Console.WriteLine($"员工薪资：{_salary}");
        }
    }
}