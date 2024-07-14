param keyVaultName string

module keyvault './key-vault/key-vault.bicep' = {
  name: 'main-keyvault'
  params: {
    keyVaultName: keyVaultName
  }
}
