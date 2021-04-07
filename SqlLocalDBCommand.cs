using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Zoe13010.SQLLocalDB.GUI
{
    public static class SqlLocalDBCommand
    {
        private static Process DefaultSqlLocalDBProcess()
        {
            Process p = new Process();
            p.StartInfo.FileName = "sqllocaldb.exe";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            return p;
        }

        public static bool DetectSQLLocalDB()
        {
            try
            {
                Process p = DefaultSqlLocalDBProcess();
                p.StartInfo.Arguments = "-?";
                p.Start();
                p.WaitForExit();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static ExecuteResultEventArgs Actions(string instanceName, string actions)
        {
            Process p = DefaultSqlLocalDBProcess();
            ExecuteResultEventArgs e = new ExecuteResultEventArgs();

            try
            {
                p.StartInfo.Arguments = String.Format("{0} {1}", actions, instanceName);
                p.Start();
                p.WaitForExit();
                string s = p.StandardOutput.ReadToEnd();
                if (s.Contains("started"))
                {
                    e.ExecuteSuccessful = true;
                    e.ReturnCode = 0;
                    e.Exception = null;
                    e.Message = "Successfully started instance!";
                }
                else if (s.Contains("stopped"))
                {
                    e.ExecuteSuccessful = true;
                    e.ReturnCode = 0;
                    e.Exception = null;
                    e.Message = "Successfully stopped instance!";
                }
                else if (s.Contains("created"))
                {
                    e.ExecuteSuccessful = true;
                    e.ReturnCode = 0;
                    e.Exception = null;
                    e.Message = "Successfully created instance!";
                }
                else if (s.Contains("deleted"))
                {
                    e.ExecuteSuccessful = true;
                    e.ReturnCode = 0;
                    e.Exception = null;
                    e.Message = "Successfully created instance!";
                }
                else
                {
                    e.ExecuteSuccessful = false;
                    e.ReturnCode = 1;
                    e.Exception = null;
                    e.Message = "Failed while executing command!";
                }
            }
            catch (Exception ex)
            {
                e.Exception = ex;
                e.ExecuteSuccessful = false;
                e.ReturnCode = -1;
                e.Message = "Error while executing command!";
            }
            finally
            {
                p.Close();
                p.Dispose();
            }

            return e;
        }

        public static List<string> GetAllInstance()
        {
            Process p = DefaultSqlLocalDBProcess();
            List<string> result = new List<string>();

            try
            {
                p.StartInfo.Arguments = "i";
                p.Start();
                p.WaitForExit();
                string s = p.StandardOutput.ReadToEnd();
                string[] sArray = s.Split("\r\n");
                for (int i = 0; i < sArray.Length; i++)
                {
                    if (sArray[i].Length > 0)
                    {
                        result.Add(sArray[i]);
                    }
                }
            }
            catch
            {
                result = new List<string>();
            }
            finally
            {
                p.Close();
                p.Dispose();
            }

            return result;
        }

        public static ExecuteResultEventArgs GetInfoInstance(string instanceName)
        {
            Process p = DefaultSqlLocalDBProcess();
            ExecuteResultEventArgs e = new ExecuteResultEventArgs();
            InstanceInfo info = new InstanceInfo();

            try
            {
                p.StartInfo.Arguments = String.Format("{0} {1}", "i", instanceName);
                p.Start();
                p.WaitForExit();
                string s = p.StandardOutput.ReadToEnd();

                if (s.Contains("Version:"))
                {
                    string[] sArray = s.Split("\r\r\n");

                    for (int i = 0; i < 8; i++)
                    {
                        sArray[i] = sArray[i].Remove(0, sArray[i].IndexOf(":") + 1);
                        while (sArray[i].Length != 0 && sArray[i][0] == ' ')
                            sArray[i] = sArray[i].Remove(0, 1);
                    }

                    info.Name = sArray[0];
                    info.Version = sArray[1];
                    info.SharedName = sArray[2];
                    info.Owner = sArray[3];
                    info.AutoCreate = sArray[4] == "Yes" ? true : false;
                    info.State = sArray[5].ToLower() == "running" ? InstanceState.Running : sArray[5].ToLower() == "stopped" ? InstanceState.Stopped : InstanceState.Unknown;
                    info.LastStartTime = sArray[6];
                    info.PipeName = sArray[7];

                    e.ExecuteSuccessful = true;
                    e.ReturnCode = 0;
                    e.Exception = null;
                    e.Message = "Successfully got instance info!";
                }
                else
                {
                    info = new InstanceInfo();

                    e.ExecuteSuccessful = false;
                    e.ReturnCode = 1;
                    e.Exception = null;
                    e.Message = "Failed while getting instance info!";
                }

                e.Object = info;
            }
            catch (Exception ex)
            {
                e.Exception = ex;
                e.ExecuteSuccessful = false;
                e.ReturnCode = -1;
                e.Message = "Error while executing command!";
            }
            finally
            {
                p.Close();
                p.Dispose();
            }

            return e;
        }
    }

    public struct InstanceInfo
    {
        public string Name;
        public string Version;
        public string SharedName;
        public string Owner;
        public bool AutoCreate;
        public InstanceState State;
        public string LastStartTime;
        public string PipeName;
    }

    public enum InstanceState
    {
        Unknown = -1,
        Running = 0,
        Stopped = 1
    }

    public class ExecuteResultEventArgs : EventArgs
    {
        Exception ex = null;
        string message = null;
        bool executeSuccessful = false;
        int returnCode = -1;
        object obj = null;

        public ExecuteResultEventArgs() { }

        public Exception Exception
        {
            get { return ex; }
            set { ex = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public bool ExecuteSuccessful
        {
            get { return executeSuccessful; }
            set { executeSuccessful = value; }
        }

        public int ReturnCode
        {
            get { return returnCode; }
            set { returnCode = value; }
        }

        public object Object
        {
            get { return obj; }
            set { obj = value; }
        }
    }
}
