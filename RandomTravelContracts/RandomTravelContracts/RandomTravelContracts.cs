﻿using Harmony;
using System.Reflection;

namespace RandomTravelContracts {
    public class RandomTravelContracts {
        internal static string ModDirectory;
        public static void Init(string directory, string settingsJSON) {
            var harmony = HarmonyInstance.Create("de.morphyum.RandomTravelContracts");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
            ModDirectory = directory;

        }
    }

    


}
