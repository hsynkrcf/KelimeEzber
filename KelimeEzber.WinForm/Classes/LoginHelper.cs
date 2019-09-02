using KelimeEzber.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace KelimeEzber.WinForm.Classes
{
    public class LoginHelper
    {
        public void Create(LoginDTO login)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("EzberBozanlar.daho", FileMode.Create, FileAccess.Write);
            bf.Serialize(fs, login);
            fs.Close();
        }
        public LoginDTO Read(string filePath)
        {
            LoginDTO login = new LoginDTO();
            if (File.Exists("EzberBozanlar.daho"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream("EzberBozanlar.daho", FileMode.Open, FileAccess.Read);
                login = bf.Deserialize(fs) as LoginDTO;
                fs.Close();
            }
            return login;
        }
    }
}
