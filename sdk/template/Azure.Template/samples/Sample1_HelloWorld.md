# Get secret

To use these samples, you'll first need to set up resources. See [getting started](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/template/Azure.Template/README.md#getting-started) for details.

## Import the namespaces

```C# Snippet:Azure_Template
using Azure.Identity;
using Azure.Template.Models;
```

## Get secrets synchronously

You can create a client and get secrets synchronously:

```C# Snippet:Azure_Template_GetSecret
string endpoint = "https://myvault.vault.azure.net";
var credential = new DefaultAzureCredential();
var client = new TemplateClient(endpoint, new DefaultAzureCredential());

SecretBundle secret = client.GetSecretValue("TestSecret");

Console.WriteLine(secret.Value);
```

To see the full example source files, see:
* [HelloWorld](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/template/Azure.Template/tests/Samples/Sample1_HelloWorld.cs)