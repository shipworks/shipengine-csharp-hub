# ShipEngine.ApiClient - the C# library for the ShipEngine

No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: v1
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out ShipEngine.ApiClient.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new AddressValidationApi();
            var addresses = new List<AddressDTO>(); // List<AddressDTO> | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                List<AddressValidationResponseDTO> result = apiInstance.AddressValidationValidateAddresses(addresses, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressValidationApi.AddressValidationValidateAddresses: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.shipengine.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AddressValidationApi* | [**AddressValidationValidateAddresses**](docs/AddressValidationApi.md#addressvalidationvalidateaddresses) | **POST** /v1/addresses/validate | 
*BatchesApi* | [**BatchesAddToBatch**](docs/BatchesApi.md#batchesaddtobatch) | **POST** /v1/batches/{batch_id}/add | 
*BatchesApi* | [**BatchesCreate**](docs/BatchesApi.md#batchescreate) | **POST** /v1/batches | 
*BatchesApi* | [**BatchesGet**](docs/BatchesApi.md#batchesget) | **GET** /v1/batches/{batch_id} | 
*BatchesApi* | [**BatchesGetByExternalId**](docs/BatchesApi.md#batchesgetbyexternalid) | **GET** /v1/batches/external_batch_id/{external_batch_id} | 
*BatchesApi* | [**BatchesList**](docs/BatchesApi.md#batcheslist) | **GET** /v1/batches | 
*BatchesApi* | [**BatchesListErrors**](docs/BatchesApi.md#batcheslisterrors) | **GET** /v1/batches/{batch_id}/errors | 
*BatchesApi* | [**BatchesProcess**](docs/BatchesApi.md#batchesprocess) | **POST** /v1/batches/{batch_id}/process/labels | 
*BatchesApi* | [**BatchesRemoveFromBatch**](docs/BatchesApi.md#batchesremovefrombatch) | **POST** /v1/batches/{batch_id}/remove | 
*CarrierAccountsApi* | [**AccessWorldwideAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#accessworldwideaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/access_worldwide | 
*CarrierAccountsApi* | [**AccessWorldwideAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#accessworldwideaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/access_worldwide/{carrier_id} | 
*CarrierAccountsApi* | [**ApcAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#apcaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/apc | 
*CarrierAccountsApi* | [**ApcAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#apcaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/apc/{carrier_id} | 
*CarrierAccountsApi* | [**AsendiaAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#asendiaaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/asendia | 
*CarrierAccountsApi* | [**AsendiaAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#asendiaaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/asendia/{carrier_id} | 
*CarrierAccountsApi* | [**DHLECommerceAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#dhlecommerceaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/dhl_ecommerce | 
*CarrierAccountsApi* | [**DHLECommerceAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#dhlecommerceaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/dhl_ecommerce/{carrier_id} | 
*CarrierAccountsApi* | [**DHLExpressAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#dhlexpressaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/dhl_express | 
*CarrierAccountsApi* | [**DHLExpressAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#dhlexpressaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/dhl_express/{carrier_id} | 
*CarrierAccountsApi* | [**DHLExpressAccountCarrierGetSettings**](docs/CarrierAccountsApi.md#dhlexpressaccountcarriergetsettings) | **GET** /v1/connections/carriers/dhl_express/{carrier_id}/settings | 
*CarrierAccountsApi* | [**DHLExpressAccountCarrierUpdateSettings**](docs/CarrierAccountsApi.md#dhlexpressaccountcarrierupdatesettings) | **PUT** /v1/connections/carriers/dhl_express/{carrier_id}/settings | 
*CarrierAccountsApi* | [**DHLExpressCaAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#dhlexpresscaaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/dhl_express_ca | 
*CarrierAccountsApi* | [**DHLExpressCaAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#dhlexpresscaaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/dhl_express_ca/{carrier_id} | 
*CarrierAccountsApi* | [**DhlExpressUkAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#dhlexpressukaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/dhl_express_uk | 
*CarrierAccountsApi* | [**DhlExpressUkAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#dhlexpressukaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/dhl_express_uk/{carrier_id} | 
*CarrierAccountsApi* | [**DpdAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#dpdaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/dpd | 
*CarrierAccountsApi* | [**DpdAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#dpdaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/dpd/{carrier_id} | 
*CarrierAccountsApi* | [**EndiciaAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#endiciaaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/endicia | 
*CarrierAccountsApi* | [**EndiciaAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#endiciaaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/endicia/{carrier_id} | 
*CarrierAccountsApi* | [**FedExAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#fedexaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/fedex | 
*CarrierAccountsApi* | [**FedExAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#fedexaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/fedex/{carrier_id} | 
*CarrierAccountsApi* | [**FedExAccountCarrierGetSettings**](docs/CarrierAccountsApi.md#fedexaccountcarriergetsettings) | **GET** /v1/connections/carriers/fedex/{carrier_id}/settings | 
*CarrierAccountsApi* | [**FedExAccountCarrierUpdateSettings**](docs/CarrierAccountsApi.md#fedexaccountcarrierupdatesettings) | **PUT** /v1/connections/carriers/fedex/{carrier_id}/settings | 
*CarrierAccountsApi* | [**FedExUkAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#fedexukaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/fedex_uk | 
*CarrierAccountsApi* | [**FedExUkAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#fedexukaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/fedex_uk/{carrier_id} | 
*CarrierAccountsApi* | [**FirstMileAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#firstmileaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/firstmile | 
*CarrierAccountsApi* | [**FirstMileAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#firstmileaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/firstmile/{carrier_id} | 
*CarrierAccountsApi* | [**GlobegisticsAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#globegisticsaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/globegistics | 
*CarrierAccountsApi* | [**GlobegisticsAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#globegisticsaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/globegistics/{carrier_id} | 
*CarrierAccountsApi* | [**ImexAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#imexaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/imex | 
*CarrierAccountsApi* | [**ImexAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#imexaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/imex/{carrier_id} | 
*CarrierAccountsApi* | [**NewgisticsAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#newgisticsaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/newgistics | 
*CarrierAccountsApi* | [**NewgisticsAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#newgisticsaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/newgistics/{carrier_id} | 
*CarrierAccountsApi* | [**NewgisticsAccountCarrierUpdateSettings**](docs/CarrierAccountsApi.md#newgisticsaccountcarrierupdatesettings) | **PUT** /v1/connections/carriers/newgistics/{carrier_id}/settings | 
*CarrierAccountsApi* | [**OnTracAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#ontracaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/ontrac | 
*CarrierAccountsApi* | [**OnTracAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#ontracaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/ontrac/{carrier_id} | 
*CarrierAccountsApi* | [**PurolatorAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#purolatoraccountcarrierconnectaccount) | **POST** /v1/connections/carriers/purolator_canada | 
*CarrierAccountsApi* | [**PurolatorAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#purolatoraccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/purolator_canada/{carrier_id} | 
*CarrierAccountsApi* | [**RoyalMailAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#royalmailaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/royal_mail | 
*CarrierAccountsApi* | [**RoyalMailAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#royalmailaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/royal_mail/{carrier_id} | 
*CarrierAccountsApi* | [**RrDonnelleyAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#rrdonnelleyaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/rr_donnelley | 
*CarrierAccountsApi* | [**RrDonnelleyAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#rrdonnelleyaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/rr_donnelley/{carrier_id} | 
*CarrierAccountsApi* | [**StampsAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#stampsaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/stamps_com | 
*CarrierAccountsApi* | [**StampsAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#stampsaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/stamps_com/{carrier_id} | 
*CarrierAccountsApi* | [**StampsAccountCarrierGetAccountUrl**](docs/CarrierAccountsApi.md#stampsaccountcarriergetaccounturl) | **PUT** /v1/connections/carriers/stamps_com/{carrier_id}/request_account_url | 
*CarrierAccountsApi* | [**UPSAccountCarrierConnectAccount**](docs/CarrierAccountsApi.md#upsaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/ups | 
*CarrierAccountsApi* | [**UPSAccountCarrierDisconnectAccount**](docs/CarrierAccountsApi.md#upsaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/ups/{carrier_id} | 
*CarrierAccountsApi* | [**UPSAccountCarrierGetSettings**](docs/CarrierAccountsApi.md#upsaccountcarriergetsettings) | **GET** /v1/connections/carriers/ups/{carrier_id}/settings | 
*CarrierAccountsApi* | [**UPSAccountCarrierUpdateSettings**](docs/CarrierAccountsApi.md#upsaccountcarrierupdatesettings) | **PUT** /v1/connections/carriers/ups/{carrier_id}/settings | 
*CarriersApi* | [**CarriersAddFunds**](docs/CarriersApi.md#carriersaddfunds) | **PUT** /v1/carriers/{carrier_id}/add_funds | 
*CarriersApi* | [**CarriersGet**](docs/CarriersApi.md#carriersget) | **GET** /v1/carriers/{carrier_id} | 
*CarriersApi* | [**CarriersGetOptions**](docs/CarriersApi.md#carriersgetoptions) | **GET** /v1/carriers/{carrier_id}/options | 
*CarriersApi* | [**CarriersList**](docs/CarriersApi.md#carrierslist) | **GET** /v1/carriers | 
*CarriersApi* | [**CarriersListPackages**](docs/CarriersApi.md#carrierslistpackages) | **GET** /v1/carriers/{carrier_id}/packages | 
*CarriersApi* | [**CarriersListServices**](docs/CarriersApi.md#carrierslistservices) | **GET** /v1/carriers/{carrier_id}/services | 
*EnvironmentApi* | [**EnvironmentCreateWebhook**](docs/EnvironmentApi.md#environmentcreatewebhook) | **POST** /v1/environment/webhooks | 
*EnvironmentApi* | [**EnvironmentDeleteWebhook**](docs/EnvironmentApi.md#environmentdeletewebhook) | **DELETE** /v1/environment/webhooks/{webhook_id} | 
*EnvironmentApi* | [**EnvironmentGetWebhookById**](docs/EnvironmentApi.md#environmentgetwebhookbyid) | **GET** /v1/environment/webhooks/{webhook_id} | 
*EnvironmentApi* | [**EnvironmentUpdateWebhook**](docs/EnvironmentApi.md#environmentupdatewebhook) | **PUT** /v1/environment/webhooks/{webhook_id} | 
*EnvironmentApi* | [**EnvironmentWebhooks**](docs/EnvironmentApi.md#environmentwebhooks) | **GET** /v1/environment/webhooks | 
*EnvironmentApi* | [**EnvironmentWhoami**](docs/EnvironmentApi.md#environmentwhoami) | **GET** /v1/environment/whoami | 
*InsuranceApi* | [**InsuranceAddFunds**](docs/InsuranceApi.md#insuranceaddfunds) | **PATCH** /v1/insurance/shipsurance/add_funds | 
*InsuranceApi* | [**InsuranceGetBalance**](docs/InsuranceApi.md#insurancegetbalance) | **GET** /v1/insurance/shipsurance/balance | 
*LabelsApi* | [**LabelsGet**](docs/LabelsApi.md#labelsget) | **GET** /v1/labels/{label_id} | 
*LabelsApi* | [**LabelsList**](docs/LabelsApi.md#labelslist) | **GET** /v1/labels | 
*LabelsApi* | [**LabelsPurchaseLabel**](docs/LabelsApi.md#labelspurchaselabel) | **POST** /v1/labels | 
*LabelsApi* | [**LabelsPurchaseLabelWithRate**](docs/LabelsApi.md#labelspurchaselabelwithrate) | **POST** /v1/labels/rates/{rate_id} | 
*LabelsApi* | [**LabelsPurchaseLabelWithShipment**](docs/LabelsApi.md#labelspurchaselabelwithshipment) | **POST** /v1/labels/shipment/{shipment_id} | 
*LabelsApi* | [**LabelsTrack**](docs/LabelsApi.md#labelstrack) | **GET** /v1/labels/{label_id}/track | 
*LabelsApi* | [**LabelsVoidLabel**](docs/LabelsApi.md#labelsvoidlabel) | **PUT** /v1/labels/{label_id}/void | 
*ManifestsApi* | [**ManifestsCreate**](docs/ManifestsApi.md#manifestscreate) | **POST** /v1/manifests | 
*ManifestsApi* | [**ManifestsGet**](docs/ManifestsApi.md#manifestsget) | **GET** /v1/manifests/{manifest_id} | 
*ManifestsApi* | [**ManifestsList**](docs/ManifestsApi.md#manifestslist) | **GET** /v1/manifests | 
*MarketplaceAccountsApi* | [**AmazonAccountConnect**](docs/MarketplaceAccountsApi.md#amazonaccountconnect) | **POST** /v-beta/connections/marketplaces/amazon | 
*MarketplaceAccountsApi* | [**AmazonAccountDeactivate**](docs/MarketplaceAccountsApi.md#amazonaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/amazon/{store_id}/deactivate | 
*MarketplaceAccountsApi* | [**AmazonAccountReactivate**](docs/MarketplaceAccountsApi.md#amazonaccountreactivate) | **PUT** /v-beta/connections/marketplaces/amazon/{store_id}/reactivate | 
*MarketplaceAccountsApi* | [**AmazonAccountTest**](docs/MarketplaceAccountsApi.md#amazonaccounttest) | **GET** /v-beta/connections/marketplaces/amazon/{store_id}/test | 
*MarketplaceAccountsApi* | [**AmazonAccountUpdateSettings**](docs/MarketplaceAccountsApi.md#amazonaccountupdatesettings) | **GET** /v-beta/connections/marketplaces/amazon/{store_id}/settings | 
*MarketplaceAccountsApi* | [**AmazonCaAccountConnect**](docs/MarketplaceAccountsApi.md#amazoncaaccountconnect) | **POST** /v-beta/connections/marketplaces/amazon_ca | 
*MarketplaceAccountsApi* | [**AmazonCaAccountDeactivate**](docs/MarketplaceAccountsApi.md#amazoncaaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/amazon_ca/{store_id}/deactivate | 
*MarketplaceAccountsApi* | [**AmazonCaAccountReactivate**](docs/MarketplaceAccountsApi.md#amazoncaaccountreactivate) | **PUT** /v-beta/connections/marketplaces/amazon_ca/{store_id}/reactivate | 
*MarketplaceAccountsApi* | [**AmazonCaAccountTest**](docs/MarketplaceAccountsApi.md#amazoncaaccounttest) | **GET** /v-beta/connections/marketplaces/amazon_ca/{store_id}/test | 
*MarketplaceAccountsApi* | [**AmazonCaAccountUpdateSettings**](docs/MarketplaceAccountsApi.md#amazoncaaccountupdatesettings) | **GET** /v-beta/connections/marketplaces/amazon_ca/{store_id}/settings | 
*MarketplaceAccountsApi* | [**BrightpearlAccountConnect**](docs/MarketplaceAccountsApi.md#brightpearlaccountconnect) | **POST** /v-beta/connections/marketplaces/brightpearl | 
*MarketplaceAccountsApi* | [**BrightpearlAccountDeactivate**](docs/MarketplaceAccountsApi.md#brightpearlaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/brightpearl/{store_id}/deactivate | 
*MarketplaceAccountsApi* | [**BrightpearlAccountReactivate**](docs/MarketplaceAccountsApi.md#brightpearlaccountreactivate) | **PUT** /v-beta/connections/marketplaces/brightpearl/{store_id}/reactivate | 
*MarketplaceAccountsApi* | [**BrightpearlAccountTest**](docs/MarketplaceAccountsApi.md#brightpearlaccounttest) | **GET** /v-beta/connections/marketplaces/brightpearl/{store_id}/test | 
*MarketplaceAccountsApi* | [**BrightpearlAccountUpdateSettings**](docs/MarketplaceAccountsApi.md#brightpearlaccountupdatesettings) | **PUT** /v-beta/connections/marketplaces/brightpearl/{store_id}/settings | 
*MarketplaceAccountsApi* | [**ChannelAdvisorAccountConnect**](docs/MarketplaceAccountsApi.md#channeladvisoraccountconnect) | **POST** /v-beta/connections/marketplaces/channeladvisor | 
*MarketplaceAccountsApi* | [**ChannelAdvisorAccountDeactivate**](docs/MarketplaceAccountsApi.md#channeladvisoraccountdeactivate) | **PUT** /v-beta/connections/marketplaces/channeladvisor/{store_id}/deactivate | 
*MarketplaceAccountsApi* | [**ChannelAdvisorAccountReactivate**](docs/MarketplaceAccountsApi.md#channeladvisoraccountreactivate) | **PUT** /v-beta/connections/marketplaces/channeladvisor/{store_id}/reactivate | 
*MarketplaceAccountsApi* | [**ChannelAdvisorAccountTest**](docs/MarketplaceAccountsApi.md#channeladvisoraccounttest) | **GET** /v-beta/connections/marketplaces/channeladvisor/{store_id}/test | 
*MarketplaceAccountsApi* | [**ChannelAdvisorAccountUpdateSettings**](docs/MarketplaceAccountsApi.md#channeladvisoraccountupdatesettings) | **PUT** /v-beta/connections/marketplaces/channeladvisor/{store_id}/settings | 
*MarketplaceAccountsApi* | [**EbayAccountConnectAccessToken**](docs/MarketplaceAccountsApi.md#ebayaccountconnectaccesstoken) | **POST** /v-beta/connections/marketplaces/ebay/access_token | 
*MarketplaceAccountsApi* | [**EbayAccountDeactivate**](docs/MarketplaceAccountsApi.md#ebayaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/ebay/{store_id}/deactivate | 
*MarketplaceAccountsApi* | [**EbayAccountReactivate**](docs/MarketplaceAccountsApi.md#ebayaccountreactivate) | **PUT** /v-beta/connections/marketplaces/ebay/{store_id}/reactivate | 
*MarketplaceAccountsApi* | [**EbayAccountTest**](docs/MarketplaceAccountsApi.md#ebayaccounttest) | **GET** /v-beta/connections/marketplaces/ebay/{store_id}/test | 
*MarketplaceAccountsApi* | [**EbayAccountUpdateSettings**](docs/MarketplaceAccountsApi.md#ebayaccountupdatesettings) | **PUT** /v-beta/connections/marketplaces/ebay/{store_id}/settings | 
*MarketplaceAccountsApi* | [**EtsyAccountConnect**](docs/MarketplaceAccountsApi.md#etsyaccountconnect) | **POST** /v-beta/connections/marketplaces/etsy/access_token | 
*MarketplaceAccountsApi* | [**EtsyAccountDeactivate**](docs/MarketplaceAccountsApi.md#etsyaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/etsy/{store_id}/deactivate | 
*MarketplaceAccountsApi* | [**EtsyAccountReactivate**](docs/MarketplaceAccountsApi.md#etsyaccountreactivate) | **PUT** /v-beta/connections/marketplaces/etsy/{store_id}/reactivate | 
*MarketplaceAccountsApi* | [**EtsyAccountTest**](docs/MarketplaceAccountsApi.md#etsyaccounttest) | **GET** /v-beta/connections/marketplaces/etsy/{store_id}/test | 
*MarketplaceAccountsApi* | [**EtsyAccountUpdateSettings**](docs/MarketplaceAccountsApi.md#etsyaccountupdatesettings) | **PUT** /v-beta/connections/marketplaces/etsy/{store_id}/settings | 
*MarketplaceAccountsApi* | [**MagentoAccountConnect**](docs/MarketplaceAccountsApi.md#magentoaccountconnect) | **POST** /v-beta/connections/marketplaces/magento | 
*MarketplaceAccountsApi* | [**MagentoAccountDeactivate**](docs/MarketplaceAccountsApi.md#magentoaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/magento/{store_id}/deactivate | 
*MarketplaceAccountsApi* | [**MagentoAccountReactivate**](docs/MarketplaceAccountsApi.md#magentoaccountreactivate) | **PUT** /v-beta/connections/marketplaces/magento/{store_id}/reactivate | 
*MarketplaceAccountsApi* | [**MagentoAccountTest**](docs/MarketplaceAccountsApi.md#magentoaccounttest) | **GET** /v-beta/connections/marketplaces/magento/{store_id}/test | 
*MarketplaceAccountsApi* | [**MagentoAccountUpdateSettings**](docs/MarketplaceAccountsApi.md#magentoaccountupdatesettings) | **PUT** /v-beta/connections/marketplaces/magento/{store_id}/settings | 
*MarketplaceAccountsApi* | [**ShopifyAccountConnectAccessToken**](docs/MarketplaceAccountsApi.md#shopifyaccountconnectaccesstoken) | **POST** /v-beta/connections/marketplaces/shopify/access_token | 
*MarketplaceAccountsApi* | [**ShopifyAccountDeactivate**](docs/MarketplaceAccountsApi.md#shopifyaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/shopify/{store_id}/deactivate | 
*MarketplaceAccountsApi* | [**ShopifyAccountReactivate**](docs/MarketplaceAccountsApi.md#shopifyaccountreactivate) | **PUT** /v-beta/connections/marketplaces/shopify/{store_id}/reactivate | 
*MarketplaceAccountsApi* | [**ShopifyAccountTest**](docs/MarketplaceAccountsApi.md#shopifyaccounttest) | **GET** /v-beta/connections/marketplaces/shopify/{store_id}/test | 
*MarketplaceAccountsApi* | [**ShopifyAccountUpdateSettings**](docs/MarketplaceAccountsApi.md#shopifyaccountupdatesettings) | **PUT** /v-beta/connections/marketplaces/shopify/{store_id}/settings | 
*MarketplaceAccountsApi* | [**ThreeDCartAccountConnect**](docs/MarketplaceAccountsApi.md#threedcartaccountconnect) | **POST** /v-beta/connections/marketplaces/threedcart/access_token | 
*MarketplaceAccountsApi* | [**ThreeDCartAccountDeactivate**](docs/MarketplaceAccountsApi.md#threedcartaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/threedcart/{store_id}/deactivate | 
*MarketplaceAccountsApi* | [**ThreeDCartAccountReactivate**](docs/MarketplaceAccountsApi.md#threedcartaccountreactivate) | **PUT** /v-beta/connections/marketplaces/threedcart/{store_id}/reactivate | 
*MarketplaceAccountsApi* | [**ThreeDCartAccountTest**](docs/MarketplaceAccountsApi.md#threedcartaccounttest) | **GET** /v-beta/connections/marketplaces/threedcart/{store_id}/test | 
*MarketplaceAccountsApi* | [**ThreeDCartAccountUpdateSettings**](docs/MarketplaceAccountsApi.md#threedcartaccountupdatesettings) | **PUT** /v-beta/connections/marketplaces/threedcart/{store_id}/settings | 
*NLPApi* | [**NLPRecognizeAddress**](docs/NLPApi.md#nlprecognizeaddress) | **PUT** /v1/addresses/recognize | Identifies address-related entities (name, line1, line2, city, postal code, etc.) in unstructured text 
*NLPApi* | [**NLPRecognizeShipment**](docs/NLPApi.md#nlprecognizeshipment) | **PUT** /v1/shipments/recognize | Identifies shipment-related entities (names, address parts, package dimensions, weight, insurance options, etc.) in unstructured text 
*PackagesApi* | [**PackagesCreate**](docs/PackagesApi.md#packagescreate) | **POST** /v1/packages | 
*PackagesApi* | [**PackagesDelete**](docs/PackagesApi.md#packagesdelete) | **DELETE** /v1/packages/{package_id} | 
*PackagesApi* | [**PackagesGet**](docs/PackagesApi.md#packagesget) | **GET** /v1/packages/{package_id} | 
*PackagesApi* | [**PackagesList**](docs/PackagesApi.md#packageslist) | **GET** /v1/packages | 
*PackagesApi* | [**PackagesUpdate**](docs/PackagesApi.md#packagesupdate) | **PUT** /v1/packages/{package_id} | 
*RatesApi* | [**RatesEstimate**](docs/RatesApi.md#ratesestimate) | **POST** /v1/rates/estimate | 
*RatesApi* | [**RatesGet**](docs/RatesApi.md#ratesget) | **GET** /v1/rates/{rate_id} | 
*RatesApi* | [**RatesRateShipment**](docs/RatesApi.md#ratesrateshipment) | **POST** /v1/rates | 
*RatesApi* | [**RatesRateShipmentsAsync**](docs/RatesApi.md#ratesrateshipmentsasync) | **POST** /v1/rates/bulk | 
*ShipmentsApi* | [**ShipmentsAddTag**](docs/ShipmentsApi.md#shipmentsaddtag) | **POST** /v1/shipments/{shipment_id}/tags/{tag} | 
*ShipmentsApi* | [**ShipmentsCancel**](docs/ShipmentsApi.md#shipmentscancel) | **PUT** /v1/shipments/{shipment_id}/cancel | 
*ShipmentsApi* | [**ShipmentsCreateShipments**](docs/ShipmentsApi.md#shipmentscreateshipments) | **POST** /v1/shipments | 
*ShipmentsApi* | [**ShipmentsGet**](docs/ShipmentsApi.md#shipmentsget) | **GET** /v1/shipments/{shipment_id} | 
*ShipmentsApi* | [**ShipmentsGetByExternalId**](docs/ShipmentsApi.md#shipmentsgetbyexternalid) | **GET** /v1/shipments/external_shipment_id/{external_shipment_id} | 
*ShipmentsApi* | [**ShipmentsGetRatesForShipment**](docs/ShipmentsApi.md#shipmentsgetratesforshipment) | **GET** /v1/shipments/{shipment_id}/rates | 
*ShipmentsApi* | [**ShipmentsList**](docs/ShipmentsApi.md#shipmentslist) | **GET** /v1/shipments | 
*ShipmentsApi* | [**ShipmentsListErrors**](docs/ShipmentsApi.md#shipmentslisterrors) | **GET** /v1/shipments/{shipment_id}/errors | 
*ShipmentsApi* | [**ShipmentsRemoveTag**](docs/ShipmentsApi.md#shipmentsremovetag) | **DELETE** /v1/shipments/{shipment_id}/tags/{tag} | 
*ShipmentsApi* | [**ShipmentsUpdateShipment**](docs/ShipmentsApi.md#shipmentsupdateshipment) | **PUT** /v1/shipments/{shipment_id} | 
*TagsApi* | [**TagsAddTag**](docs/TagsApi.md#tagsaddtag) | **POST** /v1/tags/{tag_name} | 
*TagsApi* | [**TagsDelete**](docs/TagsApi.md#tagsdelete) | **DELETE** /v1/tags/{tag_name} | 
*TagsApi* | [**TagsListTags**](docs/TagsApi.md#tagslisttags) | **GET** /v1/tags | 
*TagsApi* | [**TagsUpdateTag**](docs/TagsApi.md#tagsupdatetag) | **PUT** /v1/tags/{tag_name}/{new_name} | 
*TrackingApi* | [**TrackingStartTracking**](docs/TrackingApi.md#trackingstarttracking) | **POST** /v1/tracking/start | 
*TrackingApi* | [**TrackingStopTracking**](docs/TrackingApi.md#trackingstoptracking) | **POST** /v1/tracking/stop | 
*TrackingApi* | [**TrackingTrack**](docs/TrackingApi.md#trackingtrack) | **GET** /v1/tracking | 
*WarehousesApi* | [**WarehousesCreate**](docs/WarehousesApi.md#warehousescreate) | **POST** /v1/warehouses | 
*WarehousesApi* | [**WarehousesDelete**](docs/WarehousesApi.md#warehousesdelete) | **DELETE** /v1/warehouses/{warehouse_id} | 
*WarehousesApi* | [**WarehousesGet**](docs/WarehousesApi.md#warehousesget) | **GET** /v1/warehouses/{warehouse_id} | 
*WarehousesApi* | [**WarehousesList**](docs/WarehousesApi.md#warehouseslist) | **GET** /v1/warehouses | 
*WarehousesApi* | [**WarehousesUpdate**](docs/WarehousesApi.md#warehousesupdate) | **PUT** /v1/warehouses/{warehouse_id} | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccessWorldwideAccountInformationDTO](docs/AccessWorldwideAccountInformationDTO.md)
 - [Model.AddressDTO](docs/AddressDTO.md)
 - [Model.AddressValidatingShipment](docs/AddressValidatingShipment.md)
 - [Model.AddressValidationResponseDTO](docs/AddressValidationResponseDTO.md)
 - [Model.AdvancedOptions](docs/AdvancedOptions.md)
 - [Model.AmazonAccountInformationRequest](docs/AmazonAccountInformationRequest.md)
 - [Model.ApcAccountInformationDTO](docs/ApcAccountInformationDTO.md)
 - [Model.ApiErrorDTO](docs/ApiErrorDTO.md)
 - [Model.ApiErrorResponseDTO](docs/ApiErrorResponseDTO.md)
 - [Model.AsendiaAccountInformationDTO](docs/AsendiaAccountInformationDTO.md)
 - [Model.BalanceResponse](docs/BalanceResponse.md)
 - [Model.Batch](docs/Batch.md)
 - [Model.BatchResponseError](docs/BatchResponseError.md)
 - [Model.BatchResponseErrors](docs/BatchResponseErrors.md)
 - [Model.BrightpearlAccountInformationRequest](docs/BrightpearlAccountInformationRequest.md)
 - [Model.BrightpearlAccountSettingsRequest](docs/BrightpearlAccountSettingsRequest.md)
 - [Model.Carrier](docs/Carrier.md)
 - [Model.CarrierAdvancedOption](docs/CarrierAdvancedOption.md)
 - [Model.CarrierListOptionsResponse](docs/CarrierListOptionsResponse.md)
 - [Model.CarrierListPackagesResponse](docs/CarrierListPackagesResponse.md)
 - [Model.CarrierListResponse](docs/CarrierListResponse.md)
 - [Model.CarrierListServicesResponse](docs/CarrierListServicesResponse.md)
 - [Model.ChannelAdvisorAccountInformationRequest](docs/ChannelAdvisorAccountInformationRequest.md)
 - [Model.ConnectAccountResponseDTO](docs/ConnectAccountResponseDTO.md)
 - [Model.ConnectMarketplaceResponseDTO](docs/ConnectMarketplaceResponseDTO.md)
 - [Model.CreateBatchRequest](docs/CreateBatchRequest.md)
 - [Model.CreateManifestRequest](docs/CreateManifestRequest.md)
 - [Model.CreateShipmentResponse](docs/CreateShipmentResponse.md)
 - [Model.CreateShipmentsRequest](docs/CreateShipmentsRequest.md)
 - [Model.CreateShipmentsResponse](docs/CreateShipmentsResponse.md)
 - [Model.CreateWebhookRequest](docs/CreateWebhookRequest.md)
 - [Model.CustomsItem](docs/CustomsItem.md)
 - [Model.DHLECommerceAccountInformationDTO](docs/DHLECommerceAccountInformationDTO.md)
 - [Model.DHLExpressAccountInformationDTO](docs/DHLExpressAccountInformationDTO.md)
 - [Model.DHLExpressAccountSettingsDTO](docs/DHLExpressAccountSettingsDTO.md)
 - [Model.DHLExpressCaAccountInformationRequest](docs/DHLExpressCaAccountInformationRequest.md)
 - [Model.DHLExpressUkAccountInformationDTO](docs/DHLExpressUkAccountInformationDTO.md)
 - [Model.DefaultAccountSettingsRequest](docs/DefaultAccountSettingsRequest.md)
 - [Model.Dimensions](docs/Dimensions.md)
 - [Model.DpdAccountInformationRequest](docs/DpdAccountInformationRequest.md)
 - [Model.EbayAccessTokenRequest](docs/EbayAccessTokenRequest.md)
 - [Model.EndiciaAccountInformationDTO](docs/EndiciaAccountInformationDTO.md)
 - [Model.EtsyAccessTokenRequest](docs/EtsyAccessTokenRequest.md)
 - [Model.FedExAccountInformationDTO](docs/FedExAccountInformationDTO.md)
 - [Model.FedExAccountSettingsDTO](docs/FedExAccountSettingsDTO.md)
 - [Model.FedExUkAccountInformationRequest](docs/FedExUkAccountInformationRequest.md)
 - [Model.FirstMileAccountInformationDTO](docs/FirstMileAccountInformationDTO.md)
 - [Model.GlobegisticsAccountInformationDTO](docs/GlobegisticsAccountInformationDTO.md)
 - [Model.ImexAccountInformationDTO](docs/ImexAccountInformationDTO.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InternationalOptions](docs/InternationalOptions.md)
 - [Model.Label](docs/Label.md)
 - [Model.LabelMessages](docs/LabelMessages.md)
 - [Model.LabelPackage](docs/LabelPackage.md)
 - [Model.LinkDTO](docs/LinkDTO.md)
 - [Model.ListBatchResponse](docs/ListBatchResponse.md)
 - [Model.ListLabelResponse](docs/ListLabelResponse.md)
 - [Model.ListManifestsRequest](docs/ListManifestsRequest.md)
 - [Model.ListManifestsResponse](docs/ListManifestsResponse.md)
 - [Model.ListShipmentResponse](docs/ListShipmentResponse.md)
 - [Model.ListTagResponse](docs/ListTagResponse.md)
 - [Model.MagentoAccountInformationRequest](docs/MagentoAccountInformationRequest.md)
 - [Model.MagentoAccountSettingsRequest](docs/MagentoAccountSettingsRequest.md)
 - [Model.ManifestResponse](docs/ManifestResponse.md)
 - [Model.ModifyBatchRequest](docs/ModifyBatchRequest.md)
 - [Model.MoneyDTO](docs/MoneyDTO.md)
 - [Model.NewgisticsAccountInformationDTO](docs/NewgisticsAccountInformationDTO.md)
 - [Model.NewgisticsAccountSettingsDTO](docs/NewgisticsAccountSettingsDTO.md)
 - [Model.OnTracAccountInformationDTO](docs/OnTracAccountInformationDTO.md)
 - [Model.Package](docs/Package.md)
 - [Model.PackagesListResponse](docs/PackagesListResponse.md)
 - [Model.PaginationLinkDTO](docs/PaginationLinkDTO.md)
 - [Model.ProcessBatchRequest](docs/ProcessBatchRequest.md)
 - [Model.ProviderError](docs/ProviderError.md)
 - [Model.PurchaseLabelRequest](docs/PurchaseLabelRequest.md)
 - [Model.PurchaseLabelWithoutShipmentRequest](docs/PurchaseLabelWithoutShipmentRequest.md)
 - [Model.PurolatorAccountInformationRequest](docs/PurolatorAccountInformationRequest.md)
 - [Model.Rate](docs/Rate.md)
 - [Model.RateEstimateRequest](docs/RateEstimateRequest.md)
 - [Model.RateRequest](docs/RateRequest.md)
 - [Model.RateResponse](docs/RateResponse.md)
 - [Model.RateResponseAsync](docs/RateResponseAsync.md)
 - [Model.RateShipmentRequest](docs/RateShipmentRequest.md)
 - [Model.RateShipmentResponse](docs/RateShipmentResponse.md)
 - [Model.RateShipmentsRequest](docs/RateShipmentsRequest.md)
 - [Model.RecognizeAddressRequestDTO](docs/RecognizeAddressRequestDTO.md)
 - [Model.RecognizeShipmentRequestDTO](docs/RecognizeShipmentRequestDTO.md)
 - [Model.RecognizedEntity](docs/RecognizedEntity.md)
 - [Model.ResponseMessageDTO](docs/ResponseMessageDTO.md)
 - [Model.RoyalMailAccountInformationRequest](docs/RoyalMailAccountInformationRequest.md)
 - [Model.RrDonnelleyAccountInformationDTO](docs/RrDonnelleyAccountInformationDTO.md)
 - [Model.Service](docs/Service.md)
 - [Model.Shipment](docs/Shipment.md)
 - [Model.ShipmentAddTagResponse](docs/ShipmentAddTagResponse.md)
 - [Model.ShipmentPackage](docs/ShipmentPackage.md)
 - [Model.ShipmentResponseError](docs/ShipmentResponseError.md)
 - [Model.ShipmentResponseErrors](docs/ShipmentResponseErrors.md)
 - [Model.ShopifyAccessTokenRequest](docs/ShopifyAccessTokenRequest.md)
 - [Model.StampsAccountInformationDTO](docs/StampsAccountInformationDTO.md)
 - [Model.StampsAccountUrlResponse](docs/StampsAccountUrlResponse.md)
 - [Model.StampsAccountUrlsRequest](docs/StampsAccountUrlsRequest.md)
 - [Model.StampsAccountUrlsResponse](docs/StampsAccountUrlsResponse.md)
 - [Model.TagResponse](docs/TagResponse.md)
 - [Model.ThreeDCartAccessTokenRequest](docs/ThreeDCartAccessTokenRequest.md)
 - [Model.TrackEvent](docs/TrackEvent.md)
 - [Model.TrackingInformation](docs/TrackingInformation.md)
 - [Model.UPSAccountInformationDTO](docs/UPSAccountInformationDTO.md)
 - [Model.UPSAccountSettingsDTO](docs/UPSAccountSettingsDTO.md)
 - [Model.UPSInvoiceDTO](docs/UPSInvoiceDTO.md)
 - [Model.UpdateWebhookRequest](docs/UpdateWebhookRequest.md)
 - [Model.VoidLabelResponse](docs/VoidLabelResponse.md)
 - [Model.WarehouseDTO](docs/WarehouseDTO.md)
 - [Model.WarehouseListDTO](docs/WarehouseListDTO.md)
 - [Model.WarehouseRequest](docs/WarehouseRequest.md)
 - [Model.WebhookResponse](docs/WebhookResponse.md)
 - [Model.Weight](docs/Weight.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="api-key"></a>
### api-key

- **Type**: API key
- **API key parameter name**: api-key
- **Location**: HTTP header

