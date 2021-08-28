using InventoryManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement.Repository.Interfaces
{
    interface IExternalPartyRepository
    {
        ExternalParty GetByName(string name);
        ExternalParty GetById(int id);
        List<ExternalParty> GetAll();
        List<ExternalParty> GetAllByType();
        bool SaveOrUpdate(ExternalParty entity);
        bool Delete(ExternalParty entity);
    }
}
