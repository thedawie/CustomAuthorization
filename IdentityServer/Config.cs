using System;
using System.Collections.Generic;
using IdentityServer4.Models;

namespace  IdentityServer
{
    public class Config
    {
        public static IEnumerable<Client> GetClients(){
            
            var clients = new List<Client>();

            //Client1

            clients.Add(new Client(){
                ClientId = "Client 1",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = {
                    new Secret("secret".Sha256())
                }
            });
            
            return clients;
        }
    }    
}