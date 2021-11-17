using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Assets.Scripts.PersistentData {

    public enum Language {Greek, English, None};
    public enum LetterCase { None, LowerCase, UpperCase, Capitalize };

    public enum SerializationType { Xml, Binary};
    public enum PanelState { InMainMenu, InGameMenu };

    public enum Difficulty { Easy,Medium, Difficult }

    public enum CrashState { Alive, Dead };
    public enum RocketState { None, StartEngines, StartEnginesMove, StartMoving }

    public class Enums {
        public static event Action<CrashState> CrashStateChanged;

        private static CrashState crashState = CrashState.Alive;
        public static CrashState CrashState
        {
            get { return crashState; }
            set
            {
                crashState = value;
                CrashStateChanged?.Invoke(crashState);
            }
        }

        public static void OnCrashStateChanged()
        {
            Console.WriteLine("From ENUMS");
            CrashStateChanged?.Invoke(CrashState);
        }
        public static Language LanguageFromString(string stringenum) {
            if (stringenum.Equals(Language.Greek.ToString())) {
                return Language.Greek;
            } else if (stringenum.Equals(Language.English.ToString())) {
                return Language.English;
            } else {
                return Language.None;
            }
        }



    }
}
