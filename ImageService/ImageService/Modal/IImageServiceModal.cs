﻿namespace ImageService.Modal
{
    /// <summary>
    /// interface for the image modal
    /// </summary>
    public interface IImageServiceModal
    {
        /// <summary>
        /// The Function Addes A file to the system
        /// </summary>
        /// <param name="path">The Path of the Image from the file</param>
        /// <returns>Indication if the Addition Was Successful</returns>
        string AddFile(string path, out bool result);
        string GetConfig(out bool result);
        string RemoveHandlerFromConfig(string handler, out bool result);
        string GetLog(out bool result);
    }
}