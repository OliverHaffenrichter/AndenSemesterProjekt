using Microsoft.AspNetCore.Hosting.Server;

namespace AndenSemesterProjekt
{
    public class base64ImageUploader
    {
        private readonly IWebHostEnvironment _env;

        public base64ImageUploader(IWebHostEnvironment environment)
        {
            _env = environment;
        }
        public void UploadImage()
        {
            string x = "iVBORw0KGgoAAAANSUhEUgAAAA8AAAAPCAYAAAA71pVKAAAAGXRFWHRTb2Z0d2FyZQBBZG9iZSBJbWFnZVJlYWR5ccllPAAAAyJpVFh0WE1MOmNvbS5hZG9iZS54bXAAAAAAADw/eHBhY2tldCBiZWdpbj0i77u/IiBpZD0iVzVNME1wQ2VoaUh6cmVTek5UY3prYzlkIj8+IDx4OnhtcG1ldGEgeG1sbnM6eD0iYWRvYmU6bnM6bWV0YS8iIHg6eG1wdGs9IkFkb2JlIFhNUCBDb3JlIDUuMy1jMDExIDY2LjE0NTY2MSwgMjAxMi8wMi8wNi0xNDo1NjoyNyAgICAgICAgIj4gPHJkZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgtbnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6eG1wPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RSZWY9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZVJlZiMiIHhtcDpDcmVhdG9yVG9vbD0iQWRvYmUgUGhvdG9zaG9wIENTNiAoV2luZG93cykiIHhtcE1NOkluc3RhbmNlSUQ9InhtcC5paWQ6MTNFQTk4RTJDRkI2MTFFMkFEOTVDRTQyMDBCOUMzOTAiIHhtcE1NOkRvY3VtZW50SUQ9InhtcC5kaWQ6MTNFQTk4RTNDRkI2MTFFMkFEOTVDRTQyMDBCOUMzOTAiPiA8eG1wTU06RGVyaXZlZEZyb20gc3RSZWY6aW5zdGFuY2VJRD0ieG1wLmlpZDoxM0VBOThFMENGQjYxMUUyQUQ5NUNFNDIwMEI5QzM5MCIgc3RSZWY6ZG9jdW1lbnRJRD0ieG1wLmRpZDoxM0VBOThFMUNGQjYxMUUyQUQ5NUNFNDIwMEI5QzM5MCIvPiA8L3JkZjpEZXNjcmlwdGlvbj4gPC9yZGY6UkRGPiA8L3g6eG1wbWV0YT4gPD94cGFja2V0IGVuZD0iciI/Pkdj5GgAAAE3SURBVHjaxFM7TsNAEH0bs/GHLEGgSNCFghNQuHE6RJELcAlKeistoqDiAum4Am2aNAhxAkpKZEfEkRMv82IkgtmKFKw0nh3rvZl5M1plrcVfTwtbnK3IO80f6uohgQ5SsRieNlCtHLaaYlWO7M3F5Ad2U/Oa6HfGiLp9hHuADqU3D6hWOGqX88vT4PpueHLvrsyKJJoeEO0zloyizFZ4K4vw6X1xK6gXsclvzWyVFUmMukDQAfzd2kv8PAukFaTugVEjW2VFT9dVlaq9xLn1iYrdZA6HGgmGao4Spu3xYtxkTlWGQ43yaZAt4t46Ye4myzo4VZQF73USbkN8P1wiPdNETZ1k7pHrGBws5maZAcUMpvrA+WGB8UAhOdavAht9EySzwxKxR7HM1if7ipNNnPq3h/EpwAD3SIr+b1+pEwAAAABJRU5ErkJggg==";
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(x);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            image.Save(_env.WebRootPath.ToString() + @"/data/Images/test.png", System.Drawing.Imaging.ImageFormat.Png);
            Console.WriteLine(_env.WebRootPath.ToString() + @"/data/Images/test.png");
        }
    }
}
