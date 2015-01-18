﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Trakttv.TraktAPI;
using Trakttv.TraktAPI.Model;

namespace Trakttv
{
    //  This class handles Setter and Getter of trakt.tv Wrapper
    public class TraktSettings
    {   
      
        // old v1 APIKEY - can be replaced by user APIkey through setter!
            // static string _apiKey = "ce4d4ac977084c873da8738f949d380776756b82";
        // v2 APIKey, will be send in header of webrequest
        private const string _apiKey = "baacaca6bf0c25c0d430fa071dadb457492734f75de6f4cd71cd40de6b95545f";
        static string _token = String.Empty;
        //Login-Data needs to be set from outside trakttv class, i.e:
        //  TraktSettings.Username = SomeTextboxUsername.Text;
        //  TraktSettings.Password = SomeTextboxPassword.Text;
        static string _password = String.Empty;
        static string _username = String.Empty;
        private const string _userAgentName = "TrakttvforEmber";

        #region ApiKey
        /// <summary>
        /// ApplicationID of Ember Manager
        /// </summary>
        public static string ApiKey
        {
            get
            {
                return _apiKey;
            }
        }
        #endregion

        #region UserAgent
        /// <summary>
        /// Trakt.tv defined UserAgent used for Web Requests
        /// </summary>
        public static string UserAgent
        {
            get
            {
              //  also use version info of Trakttv Wrapper
                return _userAgentName + "|" + Assembly.GetCallingAssembly().GetName().Version.ToString();
            }
        }
         #endregion

        #region Username
        /// <summary>
        /// Trakt.tv User
        /// </summary>
        public static string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
               //TrakttvAPI.Username = _username;
            }
        }
        #endregion

        #region Password
        /// <summary>
        /// Trakt.tv Password
        /// </summary>
        public static string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                //TrakttvAPI.Password = _password;
            }
        }
        #endregion

        #region Token
        /// <summary>
        /// Session token
        /// </summary>
        public static string Token
        {
            get
            {
                return _token;
            }
            set
            {
                _token = value;
                //TrakttvAPI.Username = _username;
            }
        }
        #endregion

    }
}