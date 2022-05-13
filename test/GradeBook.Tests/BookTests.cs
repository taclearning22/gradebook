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
            book.AddGrade(68.2);
            book.AddGrade(54.6);
            book.AddGrade(56.1);

            //act
            var result = book.GetStatistics();
            
            //assert
            Assert.Equal(59.6, result.Average, 1);
            Assert.Equal(68.2, result.High, 1);
            Assert.Equal(54.6, result.Low, 1);

        }
    }
}