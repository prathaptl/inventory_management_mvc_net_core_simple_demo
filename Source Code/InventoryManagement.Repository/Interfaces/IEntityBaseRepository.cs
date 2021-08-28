using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Repository.Interfaces
{
    public interface IEntityBaseRepository <T>
    {
        T GetByName(string name);
        T GetById(int id);
        List<T> GetAll();
        bool SaveOrUpdate(T entity);
        bool Delete(T entity);
    }
}
