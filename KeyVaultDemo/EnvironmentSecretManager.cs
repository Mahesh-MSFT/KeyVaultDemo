using Microsoft.Extensions.Configuration.AzureKeyVault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault.Models;

namespace KeyVaultDemo
{
    public class EnvironmentSecretManager : IKeyVaultSecretManager
    {
        public string GetKey(SecretBundle secret)
        {
            return secret.SecretIdentifier.Name;
        }

        public bool Load(SecretItem secret)
        {
            return secret.Identifier.Name.StartsWith("sqlconn");
        }
    }
}
