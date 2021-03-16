using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPattern;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        //so we want to test the add method in the repo
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //AAA -> Arrange, Act, and Assert (Follow these when completing a test)
            //Arrange -> An overall setup
            StreamingContent content = new StreamingContent();
            StreamingContentRepository _content = new StreamingContentRepository();

            //Act -> Get/run the code to test
            bool addResult = _content.AddContentToDirectory(content);

            //Assert -> Used to get the expected outcome of a test
            Assert.IsTrue(addResult);
        }

        //Testing the Read Method
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //AAA RULES APPLY...

            //Arrange
            //creating the content
            StreamingContent content = new StreamingContent();
            //creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();
            //Adding to the repo(content)
            repo.AddContentToDirectory(content);

            //Act
            //Our plan is to store the list of streaming content within a variable
            List<StreamingContent> listOfMovies = repo.GetContent();

            //Looks through our entire list and returns true if there is a 
            bool directoryHasContent = listOfMovies.Contains(content);

            //Assert
            Assert.IsTrue(directoryHasContent);
        }

        //We will start with some private 'fields'
        private StreamingContentRepository _repo;
        private StreamingContent _content;
        private StreamingContent _content2;

        //THIS IS THE ARRANGE PART...
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            //We make a new movie here ....finally....
            _content = new StreamingContent("Rubber", "A car tire come to life with the power to make people explode",
                                            MaturityRating.R, GenreType.Drama, 4.8d);

            _content2 = new StreamingContent("Rubber-Duck", "A car tire come to life with the power to make people explode",
                                            MaturityRating.R, GenreType.Drama, 4.8d);
            //Now ADD the movie is in our 'database' (list)
            _repo.AddContentToDirectory(_content);
            _repo.AddContentToDirectory(_content2);
        }

        //Retrieve content by title
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange  ...Already done above

            //Act 
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");
            StreamingContent theFailure = _repo.GetContentByTitle("Rubber-Duck");

            //Assert
            Assert.AreEqual(_content, searchResult);
            Assert.AreEqual(_content2, theFailure);
        }

        //Test the update method
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange -> Updated version of our movie
            StreamingContent newContent = new StreamingContent("Rubber part 2", "A car tire come to life with the power to make people explode",           
                                                        MaturityRating.R, GenreType.Drama, 9.8d);

            //Act
            bool updateResult = _repo.UpdateExistingContent("Rubber", newContent);

            //Assert
            Assert.IsTrue(updateResult);
           // Console.WriteLine(GiveMeInfo());
        }


    //Test the Delete Method
    [TestMethod]
    public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act We are removing the movie here...
            bool removeResult = _repo.DeleteExistingContent(content);

            //Assert
            Assert.IsTrue(removeResult);
        }
    
    }
}
