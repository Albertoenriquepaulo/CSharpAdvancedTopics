using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class PhotoProcessor
    {
        // WITH generic delegates
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }

        //// WITH custom delegates
        //public delegate void PhotoFilterHandler(Photo photo);
        //public void Process(string path, PhotoFilterHandler filterHandler)
        //{
        //    var photo = Photo.Load(path);
        //    filterHandler(photo);
        //    photo.Save();
        //}

        // WITHOUT delegates
        //public void Process(string path)
        //{
        //    var photo = Photo.Load(path);
        //    var filters = new PhotoFilters();
        //    filters.ApplyBrightness(photo);
        //    filters.ApplyContrast(photo);
        //    filters.Resize(photo);

        //    photo.Save();
        //}

        public void Save()
        {

        }

    }
}
