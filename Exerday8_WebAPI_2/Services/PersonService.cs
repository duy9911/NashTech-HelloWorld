using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CoreAPI_ASM2.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreAPI_ASM2.Services
{
    public class PersonService
    {
        public class PersonSerVice : IPersonService
        {
            static List<PersonModel> personModelLists = new List<PersonModel>(){
            new PersonModel(){ID=1,FirstName="Ngo", LastName="Duy",Gender="Male",DayOfBirth=new DateTime(2001,9,15),BirthPlace="Thai Nguyen"}};
            public List<PersonModel> GetList()
            {
                return personModelLists;
            }

            public List<PersonModel> Create(PersonModel model)
            {
                var id = personModelLists.Max(a => a.ID);
                id += 1;
                model.ID = id;
                personModelLists.Add(model);
                return personModelLists;
            }

            public bool Delete(int id)
            {
                var deleteItem = personModelLists.FirstOrDefault(x => x.ID == id);
                if (deleteItem != null)
                {
                    return personModelLists.Remove(deleteItem);
                }
                return false;
            }

            public void Update(PersonModel model)
            {
                var selectedItem = personModelLists.FirstOrDefault(s => s.ID == model.ID);
                personModelLists.Remove(selectedItem);
                personModelLists.Add(model);
            }

            public PersonModel GetSelected(int id)
            {
                   return personModelLists.FirstOrDefault(s => s.ID == id);
            }
            public List<PersonModel> Filters(PersonModel model)
            {
                return personModelLists.Where(x => (!string.IsNullOrEmpty(model.FirstName) && string.Equals(x.FirstName, model.FirstName, StringComparison.CurrentCultureIgnoreCase)) ||
                                                   (!string.IsNullOrEmpty(model.LastName) && string.Equals(x.LastName, model.LastName, StringComparison.CurrentCultureIgnoreCase)) ||
                                                   (!string.IsNullOrEmpty(model.Gender) && string.Equals(x.Gender, model.Gender, StringComparison.CurrentCultureIgnoreCase)) ||
                                                   (!string.IsNullOrEmpty(model.BirthPlace) && string.Equals(x.BirthPlace, model.BirthPlace, StringComparison.CurrentCultureIgnoreCase))).ToList();
            }
        }
    }
}