using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is with PhotoProcessor without delegate
            //PhotoProcessor photoProcessor = new PhotoProcessor().Process("Path");


            //// This is with PhotoProcessor with custom delegate
            //PhotoProcessor photoProcessor = new PhotoProcessor();
            //PhotoProcessor.PhotoFilterHandler filterHandler = new PhotoFilters().ApplyBrightness;

            // This is with PhotoProcessor with generic delegate
            PhotoProcessor photoProcessor = new PhotoProcessor();
            Action<Photo> filterHandler = new PhotoFilters().ApplyBrightness;

            filterHandler += new PhotoFilters().ApplyContrast;
            filterHandler += new PhotoFilters().Resize;
            filterHandler += ((Photo photo) => { Console.WriteLine("Apply Remove Red Eye"); });
            filterHandler += RemovedBordersFilter;

            photoProcessor.Process("algo.jpg", filterHandler);

        }

        static void RemovedBordersFilter(Photo photo)
        {
            Console.WriteLine("Apply Removed Border");
        }
    }
}
