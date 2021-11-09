# FormsAppapi.RespondantApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiRespondantFormIdGet**](RespondantApi.md#apiRespondantFormIdGet) | **GET** /api/Respondant/{formId} | 
[**apiRespondantPost**](RespondantApi.md#apiRespondantPost) | **POST** /api/Respondant | 

<a name="apiRespondantFormIdGet"></a>
# **apiRespondantFormIdGet**
> [RespondantDto] apiRespondantFormIdGet(formId)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.RespondantApi();
let formId = 56; // Number | 

apiInstance.apiRespondantFormIdGet(formId, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **formId** | **Number**|  | 

### Return type

[**[RespondantDto]**](RespondantDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiRespondantPost"></a>
# **apiRespondantPost**
> RespondantDto apiRespondantPost(opts)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.RespondantApi();
let opts = { 
  'body': new FormsAppapi.CreateRespondantDto() // CreateRespondantDto | 
};
apiInstance.apiRespondantPost(opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
});
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreateRespondantDto**](CreateRespondantDto.md)|  | [optional] 

### Return type

[**RespondantDto**](RespondantDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

