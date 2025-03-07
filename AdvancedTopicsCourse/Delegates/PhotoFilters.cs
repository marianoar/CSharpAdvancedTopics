
namespace Delegates
{
    public class PhotoFilters
    {
        public PhotoFilters()
        {
        }

        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Appling brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Appling Contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resizing photo");
        }
    }
}