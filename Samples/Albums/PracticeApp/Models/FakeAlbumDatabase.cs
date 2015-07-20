using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeApp.Models
{
    public class FakeAlbumDatabase
    {
        List<Album> _albums = new List<Album>();

        public  List<Album> GetAll()
        {
            return _albums;
        }

        public void Add(Album album)
        {
            if (_albums.Any())
                album.AlbumId = _albums.Max(a => a.AlbumId + 1);

            else
                album.AlbumId = 1;
           
            _albums.Add(album);
        }
 

    }
}