using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(86.2);
            book.AddGrade(65.6);
            book.AddGrade(67.1);

            //act
            var result = book.GetStatistics();
            
            //assert
            Assert.Equal(73, result.Average, 1);
            Assert.Equal(68.2, result.High, 1);
            Assert.Equal(54.6, result.Low, 1);
            Assert.Equal('B', result.Letter);

        }
    }
}