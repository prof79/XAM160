//----------------------------------------------------------------------------
// <copyright file="FileAccessHelper_iOS.cs"
//      company="Markus M. Egger">
//      Copyright (C) 2018 Markus M. Egger. All rights reserved.
// </copyright>
// <author>Markus M. Egger</author>
// <description>
//      Implementation of platform-specific file operations for iOS.
// </description>
// <version>v0.9.0 2018-08-17T23:25:00+02</version>
//
// Based on Xamarin University guidance and XAM160.
//
//----------------------------------------------------------------------------

[assembly: Xamarin.Forms.Dependency(typeof(People.iOS.Utility.FileAccessHelper_iOS))]

namespace People.iOS.Utility
{
    using System;
    using System.IO;
    using People.Utility;

    /// <summary>
    /// Implementation of platform-specific file operations for iOS.
    /// </summary>
    public class FileAccessHelper_iOS : IFileAccessHelper
    {
        #region Interface IFileAccessHelper

        /// <inheritdoc />
        public string GetLocalFilePath(string fileName)
        {
            var personalFolder =
                Environment
                    .GetFolderPath(
                        Environment.SpecialFolder.Personal);

            var libraryPath =
                Path.Combine(personalFolder, "..");

            return Path.Combine(libraryPath, fileName);
        }

        #endregion
    }
}
