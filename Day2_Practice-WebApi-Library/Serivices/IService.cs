using System.Collections.Generic;
using Practice7.Models;

namespace Practice7.Serivices
{
    //using generic type
    public interface ILibrary<T>
    {
        List<T> GetList();
        T Create(T authorDTO);
        bool Delete(int Id);
        T Update(T authorDTO);
        T GetSelected(int Id);
    }

}