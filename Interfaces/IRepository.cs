using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interfaces
{
    interface IRepository<T>
    {
        List<T> Lista();
        T ReturnById(int id);
        void Insert(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int NextId();
    }
}
