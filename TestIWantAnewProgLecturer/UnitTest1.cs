using prjiLieToSirAboutUnitTesting;

namespace TestIWantAnewProgLecturer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestgetName()
        {

            DoWhatEver doWhat = new DoWhatEver();
            String Actual = doWhat.getName();
            String expected = "jeff";
            Assert.AreEqual(expected, Actual);

        }

        [TestMethod]
        public void TestgetEmail()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String actual = doWhat.getEmail();
            String expected = "jess@gmail.com";
           Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestgetDate()
        {
            DoWhatEver doWhat = new DoWhatEver();
            String actual = doWhat.getDate();
            String expected = "2024/04/04";
            Assert.AreEqual(expected, actual);


        }
    }
}