using System.Collections.Generic;
using Day7.Models;

namespace Day7.Services
{
    public interface IPersonService
    {

        List<PersonModel> GetList();
        void Create(PersonModel model);
        void Delete(int id);
        PersonModel GetSelected(int id);
        void Update(PersonModel model);

    }
}