using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.ViewModel;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SeriesFormPresentationModelTest
    {
        private SeriesFormPresentationModel _model;
        private PrivateObject _privateObject;
        private const string SERIESNAME = "test name";
        private const string SERIESDES = "test des";
        private const string MODIFYNAME = "modify name";
        private const string MODIFYDES = "modify des";

        [TestMethod]
        public void TestConstructor()
        {
            _model = new SeriesFormPresentationModel();
            _privateObject = new PrivateObject(_model);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_name"), string.Empty);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_description"), string.Empty);

            _model = new SeriesFormPresentationModel(SERIESNAME, SERIESDES);
            _privateObject = new PrivateObject(_model);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_name"), SERIESNAME);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_description"), SERIESDES);
        }

        [TestMethod]
        public void TestModifyName()
        {
            _model = new SeriesFormPresentationModel();
            _privateObject = new PrivateObject(_model);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_name"), string.Empty);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_description"), string.Empty);

            _model.ModifyName(MODIFYNAME);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_name"), MODIFYNAME);
        }

        [TestMethod]
        public void TestModifyDes()
        {
            _model = new SeriesFormPresentationModel(SERIESNAME, SERIESDES);
            _privateObject = new PrivateObject(_model);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_name"), SERIESNAME);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_description"), SERIESDES);

            _model.ModifyDescription(MODIFYDES);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_description"), MODIFYDES);
        }
       
        [TestMethod]
        public void TestIsOkButtonEnabled()
        {
            _model = new SeriesFormPresentationModel();
            Assert.IsFalse(_model.IsOkButtonEnabled);

            _model.ModifyName(MODIFYNAME);
            Assert.IsTrue(_model.IsOkButtonEnabled);
        }
    }
}
