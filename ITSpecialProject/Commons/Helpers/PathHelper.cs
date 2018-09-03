using System;
using System.Drawing;
using System.IO;

namespace ITSpecialProject.Commons.Helpers
{
    public static class PathHelper
    {
        public static string GetDesktopPath() =>
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public static string GetImagePath() =>
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "Amigoo",
                "Images");

        public static Image GetImage(string fileName) =>
            Image.FromFile(Path.Combine(GetImagePath(), fileName));

        public static Image GetDefaultAccountImage =>
            Properties.Resources.Account_100;

        #region Image Processing

        public static string CopyImage(string source)
        {
            var fileName = GenerateFileName();

            var destination = Path.Combine(GetImagePath(), fileName);

            File.Copy(source, destination, true);

            return fileName;
        }

        private static string GenerateFileName()
        {
            return new Random().Next(100000, 999999).ToString();
        }

        #endregion
    }
}
