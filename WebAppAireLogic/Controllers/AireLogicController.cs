using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAireLogic.Context;
using WebAppAireLogic.Entities;
using WebAppAireLogic.Models;

namespace WebAppAireLogic.Controllers
{
    [ApiController]
    [Route("api")]
    public class AireLogicController : Controller
    {
        public AireLogicContext _dbContext;
        public AireLogicController(AireLogicContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        [Route("/artist/{artistName}")]
        public ActionResult<ArtistDTO> GetArtistByName(string artistName)
        {
            var artist = this._dbContext.Artists.Where(a => a.Name == artistName).FirstOrDefault();
            if (artist == null)
            {
                return BadRequest("This artist does not exist in our database!");
            }

            return new ArtistDTO
            {
                Id = artist.Id,
                Name = artist.Name,
                NumberOfAlbums = artist.Albums.Count,
                NumberOfSongs = GetNumberOfSongs(artist.Albums),
                AverageNumOfWords = GetAverageWords(artist.Albums),
                MinimumWords = GetMinimumWords(artist.Albums),
                MaximumWords = GetMaximumWords(artist.Albums),
                ChangeByAlbum = AverageChangeByAlbum(artist.Albums)
            };

        }

        private float GetAverageWords(IList<Album> albums)
        {
            long wordCount = 0;
            int songCount = 0;
            foreach(var album in albums)
            {
                foreach(var song in album.Songs)
                {
                    songCount++;
                    wordCount += CountWordsFromSong(song);
                }
            }

            return (float)wordCount /(float)songCount;
        }

        private float GetAverageWordsByAlbum(Album album)
        {
            long wordCount = 0;
            int songCount = 0;
            foreach (var song in album.Songs)
            {
                songCount++;
                wordCount += CountWordsFromSong(song);
            }

            if(songCount == 0)
            {
                return 0;
            }

            return (float)wordCount / (float)songCount;
        }

        private long GetMinimumWords(IList<Album> albums)
        {
            Song minSong = null;
            foreach(var album in albums)
            {
                foreach(var song in album.Songs)
                {
                    if(minSong == null)
                    {
                        minSong = song;
                    }
                    else
                    {
                        if(CountWordsFromSong(minSong) > CountWordsFromSong(song))
                        {
                            minSong = song;
                        }
                    }
                }
            }

            return CountWordsFromSong(minSong);
        }

        private long GetMaximumWords(IList<Album> albums)
        {
            Song maxSong = null;
            foreach (var album in albums)
            {
                foreach (var song in album.Songs)
                {
                    if (maxSong == null)
                    {
                        maxSong = song;
                    }
                    else
                    {
                        if (CountWordsFromSong(maxSong) < CountWordsFromSong(song))
                        {
                            maxSong = song;
                        }
                    }
                }
            }

            return CountWordsFromSong(maxSong);
        }

        private float AverageChangeByAlbum(IList<Album> albums)
        {
            var sum = 0f;
            var albumCount = 0f;
            Album lastAlbum = null;
            foreach(var album in albums)
            {
                if(lastAlbum == null)
                {
                    lastAlbum = album;
                }
                else
                {
                    sum += GetAverageWordsByAlbum(album) - GetAverageWordsByAlbum(lastAlbum);
                    albumCount++;
                    lastAlbum = album;
                }
            }

            if(albumCount == 0)
            {
                return 0;
            }

            return sum / albumCount;
        }
        private long CountWordsFromSong(Song song)
        {
            var listOfWords = new List<string>();
            var word = "";
            foreach(var character in song.Lyrics)
            {
                if(char.IsLetterOrDigit(character))
                {
                    word += character;
                }
                else
                {
                    if(word.Length != 0)
                        listOfWords.Add(word);
                    word = "";
                }
            }

            return listOfWords.Count;
        }

        private int GetNumberOfSongs(IList<Album> albums)
        {
            var numberOfSongs = 0;
            foreach(var album in albums)
            {
                foreach(var song in album.Songs)
                {
                    numberOfSongs++;
                }
            }

            return numberOfSongs;
        }
        
    }
}
