using System;
using System.Collections.Generic;
using System.Linq;
using Practice7.Models;

namespace Practice7.Serivices
{
    public class ClientService : ILibrary<Client>
    {
        private readonly LibraryContext _context;
        public ClientService(LibraryContext context)
        {
            _context = context;
        }

        public List<Client> GetList()
        {
            return _context.Clients.ToList();
        }

        public Client Create(Client client)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {

                var Client = new Client
                {
                    ClientName = client.ClientName
                };
                _context.Clients.Add(Client);
                _context.SaveChanges();
                transaction.Commit();
                return Client;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Delete(int Id)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Clients.Remove(GetSelected(Id));
                _context.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Client Update(Client client)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                var newClient = new Client
                {
                    ClientId=client.ClientId,
                    ClientName = client.ClientName,
                };
                _context.Clients.Update(newClient);
                _context.SaveChanges();
                _context.SaveChanges();
                transaction.Commit();
                return newClient;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Client GetSelected(int Id)
        {
            var item = _context.Clients.FirstOrDefault(s => s.ClientId == Id);
            if (item != null)
            {
                return item;
            }
            return null;
        }
    }
}