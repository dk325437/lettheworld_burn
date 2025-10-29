using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lettheworld_burn
{
    [Serializable]
    public class Schedule : ISerializable
    {
        public DateTime Time { get; set; }
        public string? Content { get; set; }
        public Editor Editor { get; set; }

        public Schedule()
        {
            Content = string.Empty;
            Editor = new Editor();
        }
        public Schedule(DateTime time, string content, Editor editor)
        {
            Time = time;
            Content = content;
            Editor = editor;
        }
        public Schedule(SerializationInfo info, StreamingContext context)
        {
            Time = info.GetDateTime("Time");
            Content = info.GetString("Content");
            Editor = (Editor)info.GetValue("Editor", typeof(Editor));
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Time", Time);
            info.AddValue("Content", Content);
            info.AddValue("Editor", Editor);
        }
        
        public override string ToString()
        {
            return $"{Time.ToShortTimeString()} - {Content} [{Editor.ToString()}]";
        }
    }
        [Serializable]
    public class ScheduleData
    {
        // Giữ nguyên file extension .dat vì BinaryFormatter tạo file nhị phân
        private string filePath = Path.Combine(GetPath.path, nameof(Schedule) + ".dat");
        

        public void WriteObject(ScheduleManager scheduleList)
        {
            // Cần đảm bảo rằng tất cả các lớp (Schedule, Editor, Person, ScheduleManager)
            // đều có attribute [Serializable] và/hoặc triển khai ISerializable.

            // ⭐️ Cần khắc phục cảnh báo null nếu có
            Directory.CreateDirectory(Path.GetDirectoryName(filePath)!);

            try
            {
#pragma warning disable SYSLIB0011
                // ⭐️ THAY THẾ DataContractSerializer bằng BinaryFormatter
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    // Dùng Serialize thay vì WriteObject
                    formatter.Serialize(fileStream, scheduleList);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi ghi file: {ex.Message}");
            }
        }

        public ScheduleManager ReadObject()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File {filePath} không tồn tại. Trả về danh sách rỗng.");
                    return new ScheduleManager();
                }
#pragma warning disable SYSLIB0011

                // Code that uses obsolete API.
                // ...
                BinaryFormatter formatter = new BinaryFormatter();
                // Re-enable the warning.
#pragma warning restore SYSLIB0011
                // ⭐️ THAY THẾ DataContractSerializer bằng BinaryFormatter


                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    // Dùng Deserialize thay vì ReadObject
                    ScheduleManager scheduleManager = (ScheduleManager)formatter.Deserialize(fileStream);
                    return scheduleManager;
                }
            }
            catch (Exception ex)
            {
                // Thường gặp SerializationException nếu cấu trúc lớp thay đổi
                Console.WriteLine($"Lỗi đọc file: {ex.Message}");
                // Nếu lỗi xảy ra, trả về danh sách mới để tránh crash
                return new ScheduleManager();
            }
        }

        public List<Schedule> GetData()
        {
            ScheduleManager scheduleManager = ReadObject();
            return scheduleManager.Schedules ?? new List<Schedule>();
        }

        public void SaveData(List<Schedule> schedules)
        {
            ScheduleManager scheduleManager = new ScheduleManager(schedules);
            WriteObject(scheduleManager);
        }
    }

}
