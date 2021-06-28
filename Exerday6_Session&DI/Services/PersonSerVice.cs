using System;
using System.Collections.Generic;
using System.Linq;
using Day7.Models;

namespace Day7.Services
{
    public class PersonSerVice : IPersonService
    {
        static List<PersonModel> personModelLists = new List<PersonModel>(){
            new PersonModel(){ID=1,FirstName="Ngo", LastName="Duy",Gender="Male",DayOfBirth=new DateTime(2001,9,15),PhoneNumber="0389232053",BirthPlace="Thai Nguyen",IsGraduated="Y",Email="Ngoduy9911@gmail.com" }};
        public List<PersonModel> GetList()
        {
            return personModelLists;
        }
        public void Create(PersonModel model)
        {
            var id = personModelLists.Max(a => a.ID);
            id += 1;
            model.ID = id;
            personModelLists.Add(model);
        }

        public void Delete(int id)
        {
            personModelLists.RemoveAll(r => r.ID == id);
        }

        public void Update(PersonModel model)
        {
            var selectedObject = personModelLists.Where(s => s.ID == model.ID).FirstOrDefault();
            personModelLists.Remove(selectedObject);
            personModelLists.Add(model);
        }

        public PersonModel GetSelected(int id)
        {
            return  personModelLists.Where(s => s.ID == id).FirstOrDefault();
        }
    }
}