using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace 编程题3
{
    internal class EmployeeManager
    {
        //使用 List<Employee> 集合在内存中存储所有员工数据
        //程序启动时：判断emp.json文件是否存在，存在则读取文件、反序列化加载所有员工数据到集合；不存在则创
        //建空集合
        //程序执行新增、修改、删除任意操作后，必须立即将最新集合数据序列化，覆盖写入emp.json文件，完成数据
        //持久化
        private string _path = "./emp.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            PropertyNameCaseInsensitive = true,    //忽略大小写            
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,    // 在JSON序列化的时候中文不变
        };
        internal string Path
        {
            //Path事先验证文件路径存在,所以后续直接调用不为空的Path就好
            get
            {
                if (!File.Exists(_path)) File.Create(_path).Dispose();
                return _path;
            }
            set
            {
                if (File.Exists(value)) _path = value;
            }
        }        

        public (string, List<Employee>) ReadFile()
        {
            //由于Path事先验证文件路径存在,所以再加上文件内容验证,所以ReadFile返回值就一定不为空串,但是要注意空列表情况
            string str = File.ReadAllText(Path);
            if (string.IsNullOrEmpty(str)) return ("文件为空", new List<Employee>());
            var list = JsonSerializer.Deserialize<List<Employee>>(str, JsonOpt) ?? new List<Employee>();
            return ("读取成功", list);
        }
        public void WriteFile(List<Employee> list)
        {
            //由于Path事先验证文件路径存在,所以WriteFile直接写入就好
            File.WriteAllText(Path, JsonSerializer.Serialize(list, JsonOpt));
        }


        internal (string, List<Employee>) SearchBySalary(double salary)
        {
            if (salary <= 0) throw new ArgumentException("薪资必须大于0", nameof(salary));

            (_, List<Employee> list) = ReadFile();
            if (!(list.Count == 0))
            {
                // 这里可以根据薪资查找并处理对应的Employee对象
                List<Employee>? Employee = list?.FindAll(v => v.Salary > salary);
                if (Employee == null || Employee.Count == 0)
                {
                    return ($"薪资大于:{salary}不存在", new List<Employee>());
                }
                else
                {
                    return ("查找成功", Employee);
                }
            }
            else
            {
                return ("暂无员工数据", new List<Employee>());
            }
        }
        
        public (string, List<Employee>) Add(string id, string name, string department, string salary)
        {
            Employee Employee = new Employee(int.Parse(id), name, department, double.Parse(salary));

            //读取文件
            (_, List<Employee> list) = ReadFile();
            //添加逻辑
            list.Add(Employee);
            //写入文件
            WriteFile(list);

            return ("新增成功", list);
        }

        internal (string, List<Employee>) SearchAll()
        {
            //读取文件
            (_, List<Employee> list) = ReadFile();
            if (list.Count == 0)
            {
                return ("暂无员工数据", new List<Employee>());
            }
            return ("查找成功", list);
        }

        // 删除数据
        public string RemoveEmployee(int id)
        {
            // 删除的逻辑处理
            try
            {
                (_, List<Employee> list) = ReadFile();
                if (id <= 0) return "员工ID不能为空";
                int idx = list?.FindIndex(item => item.EmpId == id) ?? -1;
                if (idx >= 0)
                {
                    list.RemoveAt(idx);
                    // 缺失的写回文件
                    WriteFile(list);
                }
                else 
                {
                    return "员工ID不存在";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return "删除成功";
        }

        // 编辑数据
        public string EditEmployee(int id)
        {
            // 编辑的逻辑处理
            try
            {
                if (id <= 0) return "员工ID不能为空";
                (_, List<Employee> list) = ReadFile();                
                
                int findId = list.FindIndex(item => item.EmpId == id);
                if (findId >= 0) 
                {
                    Console.WriteLine("请输入薪资");
                    double newSalary = double.Parse(Console.ReadLine() ?? "0");
                    list[findId].Salary = newSalary;
                    // 写回文件
                    WriteFile(list);
                }
                else
                {
                    return "员工ID不存在";
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return "编辑成功";
        }

    }
}
