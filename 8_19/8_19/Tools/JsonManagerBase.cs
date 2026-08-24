using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace _8_19.Tools
{
    // 抽象基类：不能被直接 new，只能被继承
    public abstract class JsonManagerBase<T>
    {
        private string _filePath;

        protected JsonManagerBase(string filePath)
        {
            _filePath = filePath;
        }

        // 统一 JSON 序列化配置（子类直接用）
        protected JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            PropertyNameCaseInsensitive = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        // 文件路径属性（自动创建空文件）
        protected string FilePath
        {
            get
            {
                if (!File.Exists(_filePath))
                    File.Create(_filePath).Dispose();
                return _filePath;
            }
        }

        // 泛型读取：返回 (提示信息, 数据列表)
        public (string, List<T>) ReadData()
        {
            string str = File.ReadAllText(FilePath);
            if (string.IsNullOrEmpty(str))
                return ("文件为空", new List<T>());

            var list = JsonSerializer.Deserialize<List<T>>(str, JsonOpt)
                       ?? new List<T>();
            return ("读取成功", list);
        }

        // 泛型写入
        public string WriteData(List<T> list)
        {
            try
            {
                File.WriteAllText(FilePath, JsonSerializer.Serialize(list, JsonOpt));
                return "写入成功";
            }
            catch (Exception ex)
            {
                return $"写入失败：{ex.Message}";
            }
        }
    }
}