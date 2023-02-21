using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReminderServiceApp
{
    public class _Service
    {
        public List<Alarm> OpenFile()
        {
            List<Alarm> listArlem = new List<Alarm>();
            string filePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "time.json");
            if (File.Exists(filePath))
            {
                listArlem = JsonConvert.DeserializeObject<List<Alarm>>(File.ReadAllText(filePath));
            }

            return listArlem;
        }

        // Tạo file Json với cách 2: JsonSerializer và TextWriter
        public void WriteToFile(List<Alarm> AlarmList)
        {

            // Lấy chuỗi Json danh sách giờ
            string jsonList = JsonConvert.SerializeObject(AlarmList);

            // Sử dụng hàm Serialize và TextWriter trong thư viện System.IO
            // Lấy đường dẫn thư mục file Exe: Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location)
            string filePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "time.json");
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, jsonList);
            }
            else
            {
                File.WriteAllText(filePath, jsonList);
            }
        }
        public void WriteToLog(string text)
        {
            string filePathLog = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "ReminderServiceAppLog.txt");
            if (!File.Exists(filePathLog))
            {
                File.WriteAllText(filePathLog, text);
            }
            else
            {
                File.AppendAllText(filePathLog, text);
            }
        }
    }
}
