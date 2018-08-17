//----------------------------------------------------------------------------
// <copyright file="FileAccessHelper_UWP.cs"
//      company="Markus M. Egger">
//      Copyright (C) 2018 Markus M. Egger. All rights reserved.
// </copyright>
// <author>Markus M. Egger</author>
// <description>
//      Implementation of platform-specific file operations for
//      Universal Windows Platform (UWP).
// </description>
// <version>v0.9.0 2018-08-17T23:26:00+02</version>
//
// Based on Xamarin University guidance and XAM160.
//
//----------------------------------------------------------------------------

[assembly: Xamarin.Forms.Dependency(typeof(People.UWP.Utility.FileAccessHelper_UWP))]

namespace People.UWP.Utility
{
    using System.IO;
    using People.Utility;

    /// <summary>
    /// Implementation of platform-specific file operations for
    /// Universal Windows Platform (UWP).
    /// </summary>
    public class FileAccessHelper_UWP : IFileAccessHelper
    {
        #region Interface IFileAccessHelper

        /// <inheritdoc />
        public string GetLocalFilePath(string fileName)
        {
            var localFolderPath =
                Windows
                    .Storage
                    .ApplicationData
                    .Current
                    .LocalFolder
                    .Path;

            return Path.Combine(localFolderPath, fileName);
        }

        #endregion
    }
}
