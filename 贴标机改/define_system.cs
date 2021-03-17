using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 贴标机改
{
    /// <summary>
    /// 配置文件读写
    /// </summary>
    public static class define_system
    {
        #region 文件配置读操作
        /// <summary>
        /// 文件配置读操作
        /// </summary>
        public class TConfigReader
        {
            private Dictionary<string, string> dict = new Dictionary<string, string>();

            private string fileload;

            /// <summary>
            /// 打开文本文件给字典赋值
            /// </summary>
            /// <param name="filename"></param>
            public void DoOpen(string filename)
            {
                dict.Clear();
                string[] nLines = File.ReadAllLines(filename);
                foreach (string ls in nLines)
                {
                    int keypos = ls.IndexOf('=');
                    if (keypos > 0)
                    {
                        try
                        {
                            dict.Add(ls.Substring(0, keypos), ls.Substring(keypos + 1));
                        }
                        catch { }
                    }
                }
                fileload = Path.GetDirectoryName(filename) + "\\" + Path.GetFileNameWithoutExtension(filename);

            }
            /// <summary>
            /// 完成读取
            /// </summary>
            public void DoClose()
            {
                dict.Clear();
            }
            public int GetInt(string keyname)
            {
                if (dict.ContainsKey(keyname))
                {
                    string val = dict[keyname];
                    return int.Parse(val);
                }
                return 0;
            }
            public ushort GetUshort(string keyname)
            {
                if (dict.ContainsKey(keyname))
                {
                    string val = dict[keyname];
                    return ushort.Parse(val);
                }
                return 0;
            }
            public double GetDouble(string keyname)
            {
                if (dict.ContainsKey(keyname))
                {
                    string val = dict[keyname];
                    return double.Parse(val);
                }
                else
                    return 0;
            }
            public float GetFloat(string keyname)
            {
                if (dict.ContainsKey(keyname))
                {
                    string val = dict[keyname];
                    return float.Parse(val);
                }
                else
                    return 0;
            }
            public string GetString(string keyname)
            {
                if (dict.ContainsKey(keyname))
                {
                    return (dict[keyname]);
                }
                return null;
            }
            public bool GetBool(string keyname)
            {
                if (dict.ContainsKey(keyname))
                {
                    string val = dict[keyname];
                    if (val == "True")
                        return true;
                    else
                    if (val == "False")
                        return false;
                    if (val == "1")
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }

        } 
        #endregion
        #region 文件配置写操作
        /// <summary>
        /// 文件配置写操作
        /// </summary>
        public class TConfigWriter
        {
            private StreamWriter sw;
            private string filesave;

            public void DoOpen(string filename)
            {
                sw = new StreamWriter(filename, true, Encoding.UTF8);
                filesave = Path.GetDirectoryName(filename) + "\\" + Path.GetFileNameWithoutExtension(filename);
            }
            public void DoClose()
            {
                sw.Flush();
                sw.Close();
            }
            public void WriteDouble(string keyname, double value)
            {
                sw.WriteLine(keyname + "=" + value.ToString());
            }
            public void WriteFloat(string keyname, float value)
            {
                sw.WriteLine(keyname + "=" + value.ToString());
            }
            public void WriteInt(string keyname, int value)
            {
                sw.WriteLine(keyname + "=" + value.ToString());
            }
            public void WriteUint(string keyname, uint value)
            {
                sw.WriteLine(keyname + "=" + value.ToString());
            }
            public void WriteText(string keyname, string value)
            {
                sw.WriteLine(keyname + "=" + value);
            }
            public void WriteBool(string keyname, bool value)
            {
                sw.Write(keyname + "=" + (value ? "1" : "0"));
            }

        }

        #endregion    
    }
}
