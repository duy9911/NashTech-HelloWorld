using System.Collections.Generic;
using CoreAPI_ASM2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI_ASM2.Services
{
    public interface IPersonService
    {
        List<PersonModel> GetList();
        bool Create(PersonModel model);
        bool Delete(int id);
        PersonModel GetSelected(int id);
        void Update(PersonModel model);
        List<PersonModel> Filters(PersonModel model);

    }
}