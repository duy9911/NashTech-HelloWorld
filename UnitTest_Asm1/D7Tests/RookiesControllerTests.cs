using System;
using System.Collections.Generic;
using System.Linq;
using Day7.Controllers;
using Day7.Models;
using Day7.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace D7Tests
{
    public class Tests
    {
        private static List<PersonModel> _mockData = new List<PersonModel>(){
                                                            new PersonModel(){ID=1,FirstName="Ngo", LastName="Duy",Gender="Male",
                                                            DayOfBirth=new DateTime(2001,9,15),PhoneNumber="0389232053",
                                                            BirthPlace="Thai Nguyen",IsGraduated="Y",Email="Ngoduy9911@gmail.com" }};
        private Mock<ILogger<RookiesController>> _loggerMock;
        private Mock<IPersonService> _personServiceMock;

        [SetUp]
        public void Setup()
        {

            _loggerMock = new Mock<ILogger<RookiesController>>();
            _personServiceMock = new Mock<IPersonService>();
            _personServiceMock.Setup(a => a.GetList()).Returns(_mockData);
        }

        [Test]
        public void Index_ReturnsAViewResult_WithAListOfPersons()
        {

            //arrange
            var rookieController = new RookiesController(_loggerMock.Object, _personServiceMock.Object);

            //Act

            var result = rookieController.Index();

            //assert

            Assert.IsInstanceOf<ViewResult>(result);

            //-check type of result data
            var view = (ViewResult)result;
            Assert.IsAssignableFrom<List<PersonModel>>(view.ViewData.Model);

            //check length
            var list = (List<PersonModel>)view.ViewData.Model;
            Assert.AreEqual(_mockData.Count, list.Count);

            //check     
        }

        [Test]
        public void Detail_ReturnsHttpNotFound_WhenInputInValidId()
        {
            const int personId = 1;
            _personServiceMock.Setup(s => s.GetSelected(personId)).Returns(_mockData.FirstOrDefault(p => p.ID == personId));

            //arrange
            var rookieController = new RookiesController(_loggerMock.Object, _personServiceMock.Object);

            //Act
            var result = rookieController.Detail(personId);

            //Assert
            Assert.IsInstanceOf<NotFoundResult>(result);

            var view = (ViewResult)result;
            Assert.IsAssignableFrom<PersonModel>(view.ViewData.Model);

            //check length
            var person = (PersonModel)view.ViewData.Model;
            Assert.AreEqual(personId, person.ID);
        }

        [Test]
        public void Detail_ReturnsHttpViewResult_WhenInputIsValidId()
        {
            const int personId = 1;
            _personServiceMock.Setup(s => s.GetSelected(personId)).Returns(_mockData.FirstOrDefault(m => m.ID == personId));
            //arrange
            var rookieController = new RookiesController(_loggerMock.Object, _personServiceMock.Object);

            //Act
            var result = rookieController.Detail(personId);

            //Assert
            Assert.IsInstanceOf<ViewResult>(result);

            //-check type 
            var view = (ViewResult)result;
            Assert.IsAssignableFrom<PersonModel>(view.ViewData.Model);

            //-check length
            var person = (PersonModel)view.ViewData.Model;
            Assert.AreEqual(personId, person.ID);
        }

        [Test]
        public void Create_ReturnsBadRequest_WhenModelStageInValid()
        {
            const string key = "Error";
            const string msg = "Model is Invalid";
            //arrange
            var rookieController = new RookiesController(_loggerMock.Object, _personServiceMock.Object);
            rookieController.ModelState.AddModelError(key, msg);
            //Act
            var result = rookieController.Create(model: null);

            //Assert
            Assert.IsInstanceOf<BadRequestObjectResult>(result);

            var obj = (BadRequestObjectResult)result;
            Assert.IsAssignableFrom<SerializableError>(obj.Value);

            var errors = (SerializableError)obj.Value;
            Assert.AreEqual(1, errors.Count);

            var errorMsg = errors.TryGetValue(key, out object value);
            Assert.IsNotNull(value);
            Assert.AreEqual(msg, ((string[])value).FirstOrDefault());
        }

        [Test]
        public void Create_ReturnsHttpViewResult_WhenModelStageIsValid()
        {
            List<PersonModel> newPerson = new List<PersonModel>(){
                                                            new PersonModel(){FirstName="Ngo", LastName="Duy",Gender="Male",
                                                            DayOfBirth=new DateTime(2001,9,15),PhoneNumber="0389232053",
                                                           BirthPlace="Thai Nguyen",IsGraduated="Y",Email="Ngoduy9911@gmail.com" }};
            var newItem = newPerson.FirstOrDefault();
            _personServiceMock.Setup(s => s.Create(newItem));
            //arrange
            var rookieController = new RookiesController(_loggerMock.Object, _personServiceMock.Object);

            //Act
            var result = rookieController.Create(model: newItem);

            //Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result);
        }

        [Test]
        public void Edit_ReturnsBadRequest_WhenModelStageInValid()
        {
            const string key = "Error";
            const string msg = "Model is Invalid";
            //arrange
            var rookieController = new RookiesController(_loggerMock.Object, _personServiceMock.Object);
            rookieController.ModelState.AddModelError(key, msg);
            //Act
            var result = rookieController.Edit(model: null);

            //Assert
            Assert.IsInstanceOf<BadRequestObjectResult>(result);

            var obj = (BadRequestObjectResult)result;
            Assert.IsAssignableFrom<SerializableError>(obj.Value);

            var errors = (SerializableError)obj.Value;
            Assert.AreEqual(1, errors.Count);

            var errorMsg = errors.TryGetValue(key, out object value);
            Assert.IsNotNull(value);
            Assert.AreEqual(msg, ((string[])value).FirstOrDefault());
        }

        [Test]
        public void Edit_ReturnsHttpViewResult_WhenModelStageIsValid()
        {
            List<PersonModel> newPerson = new List<PersonModel>(){
                                                            new PersonModel(){FirstName="Tung", LastName="Ngo",Gender="Male",
                                                            DayOfBirth=new DateTime(2001,9,15),PhoneNumber="0389232053",
                                                           BirthPlace="Thai Nguyen",IsGraduated="Y",Email="Ngoduy9911@gmail.com" }};
            var newItem = newPerson.FirstOrDefault();
            _personServiceMock.Setup(s => s.Create(newItem));
            //arrange
            var rookieController = new RookiesController(_loggerMock.Object, _personServiceMock.Object);

            //Act
            var result = rookieController.Edit(model: newItem);

            //Assert
            Assert.IsInstanceOf<RedirectToActionResult>(result);
        }

        [Test]
        public void Delete_ReturnsHttpNotFound_WhenInputInValidId()
        {
            const int personId = 1;
            _personServiceMock.Setup(s => s.GetSelected(personId)).Returns((PersonModel)null);

            //arrange
            var rookieController = new RookiesController(_loggerMock.Object, _personServiceMock.Object);

            //Act
            var result = rookieController.Delete(personId);

            //Assert
            Assert.IsInstanceOf<NotFoundResult>(result);
        }

        [Test]
        public void Delete_ReturnsHttpNotFound_WhenInputIsValidId()
        {
           const int personId = 1;
            _personServiceMock.Setup(s => s.GetSelected(personId)).Returns(_mockData.FirstOrDefault(m => m.ID == personId));
            //arrange
            var rookieController = new RookiesController(_loggerMock.Object, _personServiceMock.Object);

            //Act
            var result = rookieController.Delete(personId);

            //Assert
            //work not well, because not create Mock session yet
             Assert.IsInstanceOf<RedirectToActionResult>(result);
        }
    }
}