using Practice7.Serivices;
using Microsoft.AspNetCore.Mvc;
using Practice7.Models;
using System.Collections.Generic;

namespace Practice7.Controllers
{
    public class ClientController
    {
        private readonly ClientService clientService;

        public ClientController( ClientService clientService)
        {
            this.clientService = clientService;
        }

        #region client
        [HttpGet("client")]
        public List<Client> GetListClient()
        {
            return clientService.GetList();
        }

        [HttpPost("client")]
        public Client CreateClient(ClientDTO clientDTO)
        {
            var newClient= new Client(){
                ClientName=clientDTO.ClientName,
            };
            return clientService.Create(newClient);
        }

        [HttpDelete("client")]
        public bool DeleteClient(int Id)
        {
            return clientService.Delete(Id);
        }

        [HttpPut("client")]
        public Client UpdateClient(Client client)
        {
            return clientService.Update(client);
        }
        #endregion
        
    }
}