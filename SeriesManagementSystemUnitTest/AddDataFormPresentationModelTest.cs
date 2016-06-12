using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.UI.ViewModel;
using System.ComponentModel;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class AddDataFormPresentationModelTest
    {
        private AddDataFormPresentationModel _model;
        private PrivateObject _privateObject;
        private const string SERIESNAME = "test name";
        private const string SERIESDES = "test des";
        private const string MODIFYNAME = "modify name";
        private const string MODIFYDES = "modify des";

        [TestMethod]
        public void TestConstructor()
        {
            _model = new AddDataFormPresentationModel();
            _privateObject = new PrivateObject(_model);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_name"), string.Empty);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_description"), string.Empty);

            _model = new AddDataFormPresentationModel(SERIESNAME, SERIESDES);
            _privateObject = new PrivateObject(_model);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_name"), SERIESNAME);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_description"), SERIESDES);
        }

        [TestMethod]
        public void TestModifyName()
        {
            _model = new AddDataFormPresentationModel();
            _privateObject = new PrivateObject(_model);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_name"), string.Empty);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_description"), string.Empty);

            _model.Name = MODIFYNAME;
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_name"), MODIFYNAME);
        }

        [TestMethod]
        public void TestModifyDes()
        {
            _model = new AddDataFormPresentationModel(SERIESNAME, SERIESDES);
            _privateObject = new PrivateObject(_model);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_name"), SERIESNAME);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_description"), SERIESDES);

            _model.Description = MODIFYDES;
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_description"), MODIFYDES);
        }
       
        [TestMethod]
        public void TestIsOkButtonEnabled()
        {
            _model = new AddDataFormPresentationModel();
            Assert.IsFalse(_model.IsOkButtonEnabled);

            _model.Name = MODIFYNAME;
            Assert.IsTrue(_model.IsOkButtonEnabled);
        }

        [TestMethod]
        public void TestGetter()
        {
            _model = new AddDataFormPresentationModel(SERIESNAME, SERIESDES);
            _privateObject = new PrivateObject(_model);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_name"), _model.Name);
            Assert.AreEqual(_privateObject.GetFieldOrProperty("_description"), _model.Description);
        }

        [TestMethod]
        public void TestNotify()
        {
            _model = new AddDataFormPresentationModel();
            string propertyName = string.Empty;
            Assert.AreEqual(propertyName, string.Empty);
            _model.PropertyChanged += delegate(object sender, PropertyChangedEventArgs e)
            {
                propertyName = e.PropertyName;
            };
            _model.Name = MODIFYNAME;
            Assert.AreEqual(propertyName, "IsOkButtonEnabled");
        }
    }
}
