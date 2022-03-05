using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FaceBookAppLogic
{
    public class ApplicationSettings
    {
        private static readonly string sr_FileName;

        private static readonly XmlSerializer sr_Serializer;

        private static ApplicationSettings s_ApplicationSettings;

        public static ApplicationSettings Instance
        {
            get
            {
                if (s_ApplicationSettings == null)
                {
                    s_ApplicationSettings = fromFileOrDefault();
                }

                return s_ApplicationSettings;
            }
        }

        public bool AutoLogin { get; set; }

        public Point LastWindowLocation { get; set; }

        public FormWindowState LastWindowState { get; set; }

        public string AccessToken { get; set; }

        static ApplicationSettings()
        {
            sr_FileName = Application.ExecutablePath + ".settings.xml";
            sr_Serializer = new XmlSerializer(typeof(ApplicationSettings));
        }

        private ApplicationSettings()
        {
        }

        //Change name.
        public void SaveApplicationSettings()
        {
            using (FileStream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                sr_Serializer.Serialize(stream, this);
            }
        }

        //replace to private
        private static ApplicationSettings fromFileOrDefault()
        {
            ApplicationSettings loadedThis = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    loadedThis = sr_Serializer.Deserialize(stream) as ApplicationSettings;
                }
            }
            else
            {
                loadedThis = new ApplicationSettings()
                {
                    AutoLogin = false,
                    LastWindowState = FormWindowState.Normal
                };
            }

            return loadedThis;
        }
    }
}
