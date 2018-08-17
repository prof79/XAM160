//----------------------------------------------------------------------------
// <copyright file="FileAccessHelper_Android.cs"
//      company="Markus M. Egger">
//      Copyright (C) 2018 Markus M. Egger. All rights reserved.
// </copyright>
// <author>Markus M. Egger</author>
// <description>
//      Implementation of platform-specific file operations for Android.
// </description>
// <version>v0.9.0 2018-08-17T23:25:00+02</version>
//
// Based on Xamarin University guidance and XAM160.
//
//----------------------------------------------------------------------------

[assembly: Xamarin.Forms.Dependency(typeof(People.Droid.Utility.FileAccessHelper_Android))]

namespace People.Droid.Utility
{
    using System;
    using System.IO;
    using People.Utility;

    /// <summary>
    /// Implementation of platform-specific file operations for Android.
    /// </summary>
    public class FileAccessHelper_Android : IFileAccessHelper
    {
        #region Interface IFileAccessHelper

        /// <inheritdoc />
        public string GetLocalFilePath(string fileName)
        {
            var personalFolder =
                Environment
                    .GetFolderPath(
                        Environment.SpecialFolder.Personal);

            return Path.Combine(personalFolder, fileName);
        }

        #endregion
    }
}
