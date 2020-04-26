using SerializationForGameTest.PersistentData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Assets.Scripts.PersistentData
{
    [Serializable]
    public class GeneralSettings
    {

        private float _sfxvolume = 1;
        private float _musicvolume = 1;
        private float _mastervolume = 1;
        private bool _mutemusic = false;
        private bool _mutesounds = false;

        public float SFXVolume {
            get { return _sfxvolume; }
            set { _sfxvolume = value; }
        }

        public float Musicvolume {
            get { return _musicvolume; }
            set { _musicvolume = value; }
        }
        public float Mastervolume {
            get { return _mastervolume; }
            set { _mastervolume = value; }
        }

        public bool MuteMusic {
            get { return _mutemusic; }
            set { _mutemusic = value; }
        }

        public bool MuteSounds {
            get { return _mutesounds; }
            set { _mutesounds = value; }
        }


        internal string SettingsFileBinary = "Settings.dat";
        internal string SettingsFileXml = "Settings.xml";

        [XmlElement(ElementName = "SettingsPath")]
        public string SettingsPath {
            get {
                return PathVariables.SETTINGSPATH;
            }
        }

        public void Serialize(SerializationType type) {
            if (type == SerializationType.Xml) {
                SerializetoXml();
            } else if (type == SerializationType.Binary) {
                SerializetoBinary();
            }

        }

        //save data(variables of a class) to a xml
        private void SerializetoXml() {
            try {
                if (!System.IO.Directory.Exists(SettingsPath))
                    System.IO.Directory.CreateDirectory(SettingsPath);
                string filename = System.IO.Path.Combine(SettingsPath, SettingsFileXml);
                XmlSerializer serializer = new XmlSerializer(typeof(GeneralSettings));
                using (System.IO.TextWriter writer = new System.IO.StreamWriter(filename)) {
                    serializer.Serialize(writer, this);
                }

            } catch (Exception ex) {
                //XtraMessageBox.Show("" + ex, "Error Serializing UserPreferences", MessageBoxButtons.OK, MessageBoxIcon.Error);//TODO
            }
        }

        //retrieve data from xml to initilize object/s
        private void DeserializefromXml() {
            string filename = System.IO.Path.Combine(SettingsPath, SettingsFileXml);
            if (!System.IO.File.Exists(filename))
                return;
            GeneralSettings Settings;
            XmlSerializer serializer = new XmlSerializer(typeof(GeneralSettings));
            using (System.IO.FileStream fileStream = new System.IO.FileStream(filename, System.IO.FileMode.Open)) {
                Settings = (GeneralSettings)serializer.Deserialize(fileStream);
                this._sfxvolume = Settings._sfxvolume;
                this._mastervolume = Settings._mastervolume;
                this._musicvolume = Settings._musicvolume;
                this._mutemusic = Settings._mutemusic;
                this._mutesounds = Settings._mutesounds;
            }
        }


        //save data(variables of a class) to a binaryformat
        private void SerializetoBinary() {
            try {
                if (!System.IO.Directory.Exists(SettingsPath))
                    System.IO.Directory.CreateDirectory(SettingsPath);
                string filename = Path.Combine(SettingsPath, SettingsFileBinary);
                BinaryFormatter serializer = new BinaryFormatter();
                using (Stream writer = new FileStream(filename, FileMode.Create, FileAccess.Write)) {
                    serializer.Serialize(writer, this);
                }

            } catch (Exception ex) {
                Console.WriteLine("" + ex, "Error Serializing UserDetails");//TODO
            }
        }

        //retrieve data from binary to initilize object/s
        private void DeserializefromBinary() {
            string filename = System.IO.Path.Combine(SettingsPath, SettingsFileBinary);
            if (!System.IO.File.Exists(filename))
                return;
            GeneralSettings Settings = new GeneralSettings();
            BinaryFormatter serializer = new BinaryFormatter();
            using (System.IO.FileStream fileStream = new System.IO.FileStream(filename, System.IO.FileMode.Open)) {
                Settings = (GeneralSettings)serializer.Deserialize(fileStream);
                this._sfxvolume = Settings._sfxvolume;
                this._mastervolume = Settings._mastervolume;
                this._musicvolume = Settings._musicvolume;
                this._mutemusic = Settings._mutemusic;
                this._mutesounds = Settings._mutesounds;
            }
        }


        /// <summary>
        /// Get an static <c>Settings</c> object from a xml file(Deserialize)
        /// </summary>
        public static GeneralSettings GetSettingsFromXml() {
            GeneralSettings Settings = new GeneralSettings();
            Settings.DeserializefromXml();
            return Settings;
        }

        public static GeneralSettings GetSettingsFromBinary() {
            GeneralSettings Settings = new GeneralSettings();
            Settings.DeserializefromBinary();
            return Settings;
        }

    }
}
