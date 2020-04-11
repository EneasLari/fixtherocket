using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace SerializationForGameTest.PersistentData {
    public static class PathVariables {
        public static string USERSMANAGERPATH = Path.Combine(Application.persistentDataPath, @"EducationalGames\Users");
        public static string SETTINGSPATH = Path.Combine(Application.persistentDataPath, @"EducationalGames\Settings");

    }
}
