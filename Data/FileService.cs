//using ShopMate.Service;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



//namespace ShopMate.Data
//{
//    public class FileService : IFileService
//    {
//        public async Task<string> SaveImageAsync(Stream stream, string fileName)
//        {
//            try
//            {
//                var folderPath = Path.Combine(FileSystem.AppDataDirectory, "Resources", "Images");
//                Directory.CreateDirectory(folderPath); // Create the directory if it doesn't exist
//                var filePath = Path.Combine(folderPath, fileName);

//                using (var fileStream = File.OpenWrite(filePath))
//                {
//                    await stream.CopyToAsync(fileStream);
//                }


//                return filePath;
//            }
//            catch (Exception ex)
//            {
//                // Log or handle the exception
//                Console.WriteLine($"Error saving image: {ex.Message}");
//                return null; // Return null to indicate failure
//            }
//        }
//        //public async Task<string> GetSelectedImagePathAsync(Xamarin.Essentials.FileResult mediaFile)
//        //{

//        //    try
//        //    {
//        //        var selectedImagePath = mediaFile?.FullPath;


//        //        return selectedImagePath;
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        // Log or handle the exception
//        //        Console.WriteLine($"Error getting selected image path: {ex.Message}");
//        //        return null; // Return null to indicate failure
//        //    }
//        //}
//    }

//}