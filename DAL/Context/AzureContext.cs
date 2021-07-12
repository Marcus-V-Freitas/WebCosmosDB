using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class AzureContext
    {
        private static readonly string EndpointUri = "https://localhost:8081";
        private static readonly string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
        private static readonly CosmosClient cosmosClient = new CosmosClient(EndpointUri, PrimaryKey);
        public readonly Database database;
        public readonly Container container;


        public AzureContext()
        {
            database = cosmosClient.GetDatabase("WebCosmos");
            container = database.GetContainer("Pedidos");
        }

    }
}
