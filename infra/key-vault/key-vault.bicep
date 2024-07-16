param keyVaultName string

//to fix this chum.
resource keyvault 'Microsoft.KeyVault/vaults@2023-07-01' = {
  name: keyVaultName
  location: resourceGroup().location
  tags: {
    purpose: 'testing stuff'
  }
  properties:{
    sku: {
      family: 'A'
      name: 'standard'
    }
    createMode: 'recover'
    tenantId: subscription().tenantId
    enableSoftDelete: false
    // accessPolicies: [
    //   {
    //     tenantId: subscription().tenantId
    //     objectId: 
    //   }
    // ]
  }
}
