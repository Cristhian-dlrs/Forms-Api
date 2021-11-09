# FormsAppapi.AnswerApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiAnswerPost**](AnswerApi.md#apiAnswerPost) | **POST** /api/Answer | 
[**apiAnswerQuesitonIdGet**](AnswerApi.md#apiAnswerQuesitonIdGet) | **GET** /api/Answer/{quesitonId} | 

<a name="apiAnswerPost"></a>
# **apiAnswerPost**
> AnswerDto apiAnswerPost(opts)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.AnswerApi();
let opts = { 
  'body': new FormsAppapi.CreateAnswerDto() // CreateAnswerDto | 
};
apiInstance.apiAnswerPost(opts, (error, data, response) => {
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
 **body** | [**CreateAnswerDto**](CreateAnswerDto.md)|  | [optional] 

### Return type

[**AnswerDto**](AnswerDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiAnswerQuesitonIdGet"></a>
# **apiAnswerQuesitonIdGet**
> [AnswerDto] apiAnswerQuesitonIdGet(quesitonId)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.AnswerApi();
let quesitonId = 56; // Number | 

apiInstance.apiAnswerQuesitonIdGet(quesitonId, (error, data, response) => {
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
 **quesitonId** | **Number**|  | 

### Return type

[**[AnswerDto]**](AnswerDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

