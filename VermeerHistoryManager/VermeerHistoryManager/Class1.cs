using Moonbyte.UniversalServer.PluginFramework;
using System.Collections.Generic;
using System.IO;

namespace VermeerHistoryManager
{
    public class VermeerHistoryManager : UniversalPluginFramework
    {
        #region Vars

        public List<string> Users = new List<string>();

        string UserDirectory;

        #endregion Vars

        #region Properties

        public string Name
        {
            get { return "historymanager"; }
        }

        #endregion Properties

        #region OnLoad

        public void OnLoad(string PluginSettingsDirectory)
        {
            UserDirectory = PluginSettingsDirectory + @"\Users";

            if (!Directory.Exists(UserDirectory)) { Directory.CreateDirectory(UserDirectory); }
        }

        #endregion OnLoad

        #region Invoke

        //SyncHistory [Data] - To Be Worked On
        //GetHistory [From Date] - [To Date]
        //AddHistoryValue [URL]

        public void Invoke(ClientContext Client, string[] RawCommand)
        {
            if (RawCommand[1].ToUpper() == "ADDHISTORYVALUE")
            {

            }
            else if (RawCommand[1].ToUpper() == "GETHISTORY")
            {

            }
        }

        #endregion Invoke

        #region User Exists

        public bool CheckUserExist(string Username)
        {
            DirectoryInfo di = new DirectoryInfo(UserDirectory); 
            foreach(DirectoryInfo di1 in di.GetDirectories()) { if (di1.Name == Username) { return true; } } return false;
        }

        #endregion User Exists

    }
}
