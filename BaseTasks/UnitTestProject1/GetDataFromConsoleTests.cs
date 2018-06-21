using BaseTasksLibrary;
using TypeMock.ArrangeActAssert;
using NUnit.Framework;
using Unity;


namespace BaseTasksTests
{

    public class AdderServiceTests
    {

        [TestCase("12.12", ExpectedResult = "12.12")]
        public string AddDoubleTest(string first)
        {
            BaseTasksLibrary.IAdder test = new AdderService();
            return test.AddDouble(first);

        }



        [TestCase("12", ExpectedResult = "12")]
        public string AddIntTest(string first)
        {

            BaseTasksLibrary.IAdder test = new AdderService();
            return test.AddInt(first);
        }


        [Test]
        public void AddDoubleThrowTest()
        {
            var uc = new UnityContainer();
            var svc = Isolate.Fake.Instance<AdderService>();
            Isolate.WhenCalled(() => svc.AddDouble("test")).WillReturn("teskjklt");
            uc.RegisterInstance<AdderService>(svc);
                Assert.AreEqual("test", uc.Resolve<AdderService>().AddDouble("test"));
        }



        [Test]
        public void AddIntThrowTest()
        {
            var uc = new UnityContainer();
            var svc = Isolate.Fake.Instance<AdderService>();
            Isolate.WhenCalled(() => svc.AddInt("test")).WillReturn("test");
            uc.RegisterInstance<AdderService>(svc);
                Assert.AreEqual("test", uc.Resolve<AdderService>().AddInt("test"));
        }



    }
}
