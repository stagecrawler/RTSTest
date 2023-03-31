using RTSCodingProjectDL;

namespace RequiredMethodsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAboveBelow()
        {
            //Arange
            int comp1 = 5;
            List<int> testList = new List<int>() { 1,2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int comp2 = 6;
            List<int> testList2 = new List<int>() { 1, 5, 2, 1, 10 };
            

            //Act
            AboveBelowResponse response1 = RequiredMethods.AboveBelow(testList, comp1);
            AboveBelowResponse response2 = RequiredMethods.AboveBelow(testList2, comp2);

            //Assert
            Assert.AreEqual(response1.AboveCount, 5);
            Assert.AreEqual(response1.BelowCount, 4);

            Assert.AreEqual(response2.AboveCount, 1);
            Assert.AreEqual(response2.BelowCount, 4);
        }

        [TestMethod]
        [DataRow("MyString", 2, "ngMyStri")]
        [DataRow("EnterSandman", 3, "manEnterSand")]
        public void TestStringRotation(string originalString, int amountToShiftBy, string expectedResult)
        {
            //Arange (see above)

            //Act
            string shiftedString = RequiredMethods.StringRotation(originalString, amountToShiftBy);

            //Assert
            Assert.AreEqual(shiftedString, expectedResult);
        }
    }
}