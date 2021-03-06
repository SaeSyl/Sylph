﻿using SharpRaven;
using System;

namespace Miki
{
    /// <summary>
    /// Global data for constant folder structures and versioning.
    /// </summary>
    public class Global
    {
        public static Random random = new Random();
        public static RavenClient ravenClient;

        public static int shardCount = 1;

        #region API Keys
        public static string ApiKey = "";
        public static string CarbonitexKey = "";
        public static string DiscordPwKey = "";
        public static string DiscordBotsOrgKey = "";
        public static string UrbanKey = "";

        public static string ImgurKey = "";
        public static string ImgurClientId = "";

        public static string RocketLeagueKey = "";
        public static string SteamAPIKey = "";
        public static string SharpRavenKey = "";

        public static string DatadogKey { get; internal set; }
        #endregion API Keys
    }

    public class Constants
    {
        public const string NotDefined = "$not-defined";
    }
}