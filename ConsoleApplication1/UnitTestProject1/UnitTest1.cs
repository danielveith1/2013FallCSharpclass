using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var json = ConsoleApplication1.Program.GetProfile("Jewpaltz");
            Assert.IsNotNull(json);
            Assert.IsTrue(json.Contains("Moshe"));
            
        }
        [TestMethod]
        public void TestThatDogBarks()
        {
            var d = new Dog();
            var actual = d.Bark();
            Assert.AreEqual("woof", d.Bark());

        }
        [TestMethod]
        public void TestThatDogCanSayOtherThings()
        {
            var d = new Dog();
         
            d.DogsWord = "meyow";

            d.LearnNewWord("Hello");
            d.LearnNewWord("How Are You");
            
            var actual = d.Bark();
            Assert.AreEqual("meyow", actual);

        }
        [TestMethod]
        public void TestThatDogCanSayLotsOfThings()
        {
            var d = new Dog();

            d.DogsWord = "meyow";
            var actual = d.Bark();
            Assert.AreEqual("meyow", actual);

        }
        [TestMethod]
        public void TestThatDogCanRunAtAnySpeed()
        {
            var d = new Dog();

            d.Speed = "200";
            var actual = d.Run();
            Assert.AreEqual("I am running at 200 Miles an Hour", actual);

        }
        [TestMethod]
        public void TestDelegate()
        {
            
            // not sure why I have to use the ConsoleApplication.Program before Multiply.
            ConsoleApplication1.Program.Multiply MyFunc = delegate(int x, int y)
            {
                return x * y;
            };

            Assert.AreEqual(4, MyFunc(2, 2));

            MyFunc = (x, y) => x * y;
            // look into this syntax
        
        }
        [TestMethod]
        public void TestDelegate()
        {
            Func<int, int> Squared = x => x * x;

            Assert.AreEqual(4, Squared(2));
            Assert.AreEqual(9, Squared(3));

        }

    }

}
