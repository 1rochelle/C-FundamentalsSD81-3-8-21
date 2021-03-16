using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //Read
        public List<StreamingContent> GetContent()
        {
            return _contentDirectory;
        }
        //Read -> helper method b/c used throughout this repo
        public StreamingContent GetContentByTitle(string title)
        { 
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }

            }
            return null;
        }

        public StreamingContent GetByFamilyFriendly()
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.IsFamilyFriendly)
                {
                    return content;
                }
            }
            return null;
        }


        public StreamingContent StarRating(double Rating)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.StarRating == Rating)
                {
                    return content;
                }

            }
            return null;
        }

        
        //Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.GenreType = newContent.GenreType;
                oldContent.StarRating = newContent.StarRating;

                return true;
            }
            else
            {
                return false;
            }
        }
        //Delete
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }

    }
}
