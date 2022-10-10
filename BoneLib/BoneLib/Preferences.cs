﻿using MelonLoader;

namespace BoneLib
{
    internal static class Preferences
    {
        private static MelonPreferences_Category category = MelonPreferences.CreateCategory("BoneLib");

        public static ModPref<LoggingMode> loggingMode;


        public static void Setup()
        {
            ModConsole.Msg("Starting preferences setup", LoggingMode.DEBUG);

            loggingMode = new ModPref<LoggingMode>(category, "LoggingMode", LoggingMode.NORMAL);

            ModConsole.Msg("Finished preferences setup", LoggingMode.DEBUG);
        }
    }
}
