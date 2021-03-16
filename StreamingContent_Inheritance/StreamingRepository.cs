using RepositoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {
        //We will use the same _contentDirectory from StreamingContentRepository.cs
        
        //Read -> Show
        public Show GetShowByTitle(string title)
        {
            //To find a specific show
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower()==title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }

            return null;
        }

        //Read -> Movie
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower()==title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }
            }

            return null;
        }

        //Read get all 
        public List<Show> GetAllShows()
        {
            //Use this to add our shows -> this is a "newed-up" version of the list (we will return this list)
            List<Show> allShows = new List<Show>();

            foreach (StreamingContent content in _contentDirectory)
            {
                //if the content that we find is of type Show...
                if (content is Show)
                {
                    //Add the show to the allShows list
                    allShows.Add((Show)content);
                }
            }

            return allShows;
        }

        //Read get all movies
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add(content as Movie);
                }

            }
            return allMovies;
        }

        //challenges:
        // get by RunTime/AverageRunTime
        //Get Shows with over x episodes
        //Get Shows/Movie by Rating
    }
}
