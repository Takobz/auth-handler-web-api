param keyVaultName string

resource keyvault 'Microsoft.KeyVault/vaults@2023-07-01' = {
  name: keyVaultName
  location: resourceGroup().location
  tags: {
    purpose: 'testing stuff'
  }
}
