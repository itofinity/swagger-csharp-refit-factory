# IO.Swagger - the C# library for the Swagger Petstore

This is a sample server Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/).  For this sample, you can use the api key `special-key` to test the authorization filters.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: uk.co.itofinity.codegen.CSharpRefitClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Standard >= 2.0

<a name="dependencies"></a>
## Dependencies
- [Refit](https://github.com/paulcbetts/refit) - 4.0.0-build.16 or later
- [NUnit](http://nunit.org/) - 3.7.1 or later

<a name="installation"></a>
## Installation
Generate the DLL using Visual Studio 2017 (15.3.0)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
public class Example
{
public void main()
{

    // Configure OAuth2 access token for authorization: petstore_auth
    Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

var apiInstance = new PetApi();
        var body = new Pet(); // Pet | Pet object that needs to be added to the store

try
{
    // Add a new pet to the store
apiInstance.AddPet(body);
}
catch (Exception e)
{
Debug.Print("Exception when calling PetApi.AddPet: " + e.Message );
}
}
}
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://petstore.swagger.io/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PetApi* | [**AddPet**](docs/PetApi.md#addpet) | **Post** /pet | Add a new pet to the store
*PetApi* | [**DeletePet**](docs/PetApi.md#deletepet) | **Delete** /pet/{petId} | Deletes a pet
*PetApi* | [**FindPetsByStatus**](docs/PetApi.md#findpetsbystatus) | **Get** /pet/findByStatus | Finds Pets by status
*PetApi* | [**FindPetsByTags**](docs/PetApi.md#findpetsbytags) | **Get** /pet/findByTags | Finds Pets by tags
*PetApi* | [**GetPetById**](docs/PetApi.md#getpetbyid) | **Get** /pet/{petId} | Find pet by ID
*PetApi* | [**UpdatePet**](docs/PetApi.md#updatepet) | **Put** /pet | Update an existing pet
*PetApi* | [**UpdatePetWithForm**](docs/PetApi.md#updatepetwithform) | **Post** /pet/{petId} | Updates a pet in the store with form data
*PetApi* | [**UploadFile**](docs/PetApi.md#uploadfile) | **Post** /pet/{petId}/uploadImage | uploads an image
*StoreApi* | [**DeleteOrder**](docs/StoreApi.md#deleteorder) | **Delete** /store/order/{orderId} | Delete purchase order by ID
*StoreApi* | [**GetInventory**](docs/StoreApi.md#getinventory) | **Get** /store/inventory | Returns pet inventories by status
*StoreApi* | [**GetOrderById**](docs/StoreApi.md#getorderbyid) | **Get** /store/order/{orderId} | Find purchase order by ID
*StoreApi* | [**PlaceOrder**](docs/StoreApi.md#placeorder) | **Post** /store/order | Place an order for a pet
*UserApi* | [**CreateUser**](docs/UserApi.md#createuser) | **Post** /user | Create user
*UserApi* | [**CreateUsersWithArrayInput**](docs/UserApi.md#createuserswitharrayinput) | **Post** /user/createWithArray | Creates list of users with given input array
*UserApi* | [**CreateUsersWithListInput**](docs/UserApi.md#createuserswithlistinput) | **Post** /user/createWithList | Creates list of users with given input array
*UserApi* | [**DeleteUser**](docs/UserApi.md#deleteuser) | **Delete** /user/{username} | Delete user
*UserApi* | [**GetUserByName**](docs/UserApi.md#getuserbyname) | **Get** /user/{username} | Get user by user name
*UserApi* | [**LoginUser**](docs/UserApi.md#loginuser) | **Get** /user/login | Logs user into the system
*UserApi* | [**LogoutUser**](docs/UserApi.md#logoutuser) | **Get** /user/logout | Logs out current logged in user session
*UserApi* | [**UpdateUser**](docs/UserApi.md#updateuser) | **Put** /user/{username} | Updated user


<a name="documentation-for-models"></a>
## Documentation for Models

     - [Model.ApiResponse](docs/ApiResponse.md)
     - [Model.Category](docs/Category.md)
     - [Model.Order](docs/Order.md)
     - [Model.Pet](docs/Pet.md)
     - [Model.Tag](docs/Tag.md)
     - [Model.User](docs/User.md)
    

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

    <a name="api_key"></a>
    ### api_key

    - **Type**: API key
    - **API key parameter name**: api_key
    - **Location**: HTTP header
        
    <a name="petstore_auth"></a>
    ### petstore_auth

            - **Type**: OAuth
    - **Flow**: implicit
    - **Authorization URL**: https://petstore.swagger.io/oauth/authorize
    - **Scopes**: 
      - write:pets: modify pets in your account
  - read:pets: read your pets
