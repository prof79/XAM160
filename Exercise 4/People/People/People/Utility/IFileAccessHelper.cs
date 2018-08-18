//----------------------------------------------------------------------------
// <copyright file="IFileAccessHelper.cs"
//      company="Markus M. Egger">
//      Copyright (C) 2018 Markus M. Egger. All rights reserved.
// </copyright>
// <author>Markus M. Egger</author>
// <description>
//      An interface for abstraction of platform-specific
//      file operations.
// </description>
// <version>v1.1.0 2018-08-18T00:45:00+02</version>
//
// Based on Xamarin University knowledge and guidance.
//
//----------------------------------------------------------------------------

namespace People.Utility
{
    /// <summary>
    /// An interface for abstraction of platform-specific
    /// file operations.
    /// </summary>
    public interface IFileAccessHelper
    {
        /// <summary>
        /// Get the full platform-specific path for
        /// a file in the user's storage area.
        /// </summary>
        /// <param name="fileName">
        /// The file name to resolve.
        /// </param>
        /// <returns>
        /// An absolute file system path.
        /// </returns>
        string GetLocalFilePath(string fileName);

        /// <summary>
        /// Get the full platform-specific path for
        /// a database file in the user's storage area.
        /// </summary>
        /// <param name="fileName">
        /// The database file name to resolve.
        /// </param>
        /// <returns>
        /// An absolute file system path.
        /// </returns>
        /// <remarks>
        /// This method is necessary due to specific conventions on
        /// the Android platform to use a "databases" sub-folder.
        /// </remarks>
        string GetDatabaseFilePath(string fileName);
    }
}
