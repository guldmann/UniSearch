using System.ServiceModel;
using System.IdentityModel.Selectors;
using System.Configuration;
using SipleLogger;
using Pcis.common;

namespace UniSearchServer
{

    /// <summary>
    /// Validate User. 
    /// Users are stored in app.config 
    /// password are SHA256HAshed and compared if match user is valid 
    /// </summary>
    public class CustomValidator : UserNamePasswordValidator
    {
        SimpleLogger log = new SimpleLogger();
        public override void Validate(string userName, string password)
        {
           
            if (null == userName || null == password)
            {
                log.Add("Connection using empty username or password");
                throw new FaultException("Empty Username or Empty Password");
            }
            if (!GetUser(userName, password))
            {
                log.Add("Unknown Username or Incorrect Password");
                throw new FaultException("Unknown Username or Incorrect Password");
            }
        }
        
        private bool GetUser(string userName, string password)
        {
            foreach (var key in ConfigurationManager.AppSettings)
            {
                if (key.ToString() == userName)
                {
                    if (ConfigurationManager.AppSettings[key.ToString()] == SHA256Hash.GetHashString(password))
                    {
                        log.Add($"Login user: {userName} using password ******* OK");
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
