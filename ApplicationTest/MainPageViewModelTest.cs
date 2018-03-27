using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using AnagramCheckerApp.ViewModels;

namespace AnagramCheckerAppTest
{
    [TestClass]
    public class MainPageViewModelTest
    {
        MainPageViewModel vm;

        [TestInitialize]
        public void Init()
        {
            vm = new MainPageViewModel();
        }

        [TestMethod]
        public void MainPageViewModelTest_HandlerIsNotCalled_OutputIsNull()
        {
            vm.FirstString = "set";
            vm.SecondString = "tes";

            Assert.IsNull(vm.Output);
        }

        [TestMethod]
        public void MainPageViewModelTest_InputsAreAnagram_OutputIsYes()
        {
            vm.FirstString = "Elvis";
            vm.SecondString = "Lives";
            vm.CheckAnagramHandler();
            Assert.AreEqual("Yes", vm.Output);
        }

        [TestMethod]
        public void MainPageViewModelTest_InputsAreNotAnagram_OutputIsNope()
        {
            vm.FirstString = "Elvis";
            vm.SecondString = "Legend";
            vm.CheckAnagramHandler();
            Assert.AreEqual("Nope", vm.Output);
        }
    }
}
