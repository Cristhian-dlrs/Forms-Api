# FormsAppapi.FormApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiFormGetAllUserIdGet**](FormApi.md#apiFormGetAllUserIdGet) | **GET** /api/Form/getAll/{userId} | 
[**apiFormGetWithQuestionsIdGet**](FormApi.md#apiFormGetWithQuestionsIdGet) | **GET** /api/Form/getWithQuestions/{id} | 
[**apiFormIdDelete**](FormApi.md#apiFormIdDelete) | **DELETE** /api/Form/{id} | 
[**apiFormIdGet**](FormApi.md#apiFormIdGet) | **GET** /api/Form/{id} | 
[**apiFormPost**](FormApi.md#apiFormPost) | **POST** /api/Form | 
[**apiFormPut**](FormApi.md#apiFormPut) | **PUT** /api/Form | 

<a name="apiFormGetAllUserIdGet"></a>
# **apiFormGetAllUserIdGet**
> [FormDto] apiFormGetAllUserIdGet(userId)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.FormApi();
let userId = 56; // Number | 

apiInstance.apiFormGetAllUserIdGet(userId, (error, data, response) => {
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
 **userId** | **Number**|  | 

### Return type

[**[FormDto]**](FormDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiFormGetWithQuestionsIdGet"></a>
# **apiFormGetWithQuestionsIdGet**
> FormDto apiFormGetWithQuestionsIdGet(id)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.FormApi();
let id = 56; // Number | 

apiInstance.apiFormGetWithQuestionsIdGet(id, (error, data, response) => {
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
 **id** | **Number**|  | 

### Return type

[**FormDto**](FormDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiFormIdDelete"></a>
# **apiFormIdDelete**
> &#x27;Boolean&#x27; apiFormIdDelete(id)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.FormApi();
let id = 56; // Number | 

apiInstance.apiFormIdDelete(id, (error, data, response) => {
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
 **id** | **Number**|  | 

### Return type

**&#x27;Boolean&#x27;**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiFormIdGet"></a>
# **apiFormIdGet**
> FormDto apiFormIdGet(id)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.FormApi();
let id = 56; // Number | 

apiInstance.apiFormIdGet(id, (error, data, response) => {
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
 **id** | **Number**|  | 

### Return type

[**FormDto**](FormDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

<a name="apiFormPost"></a>
# **apiFormPost**
> FormDto apiFormPost(opts)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.FormApi();
let opts = { 
  'body': new FormsAppapi.CreateFormDto() // CreateFormDto | 
};
apiInstance.apiFormPost(opts, (error, data, response) => {
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
 **body** | [**CreateFormDto**](CreateFormDto.md)|  | [optional] 

### Return type

[**FormDto**](FormDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiFormPut"></a>
# **apiFormPut**
> &#x27;Boolean&#x27; apiFormPut(opts)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.FormApi();
let opts = { 
  'body': new FormsAppapi.UpdateFormDto() // UpdateFormDto | 
};
apiInstance.apiFormPut(opts, (error, data, response) => {
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
 **body** | [**UpdateFormDto**](UpdateFormDto.md)|  | [optional] 

### Return type

**&#x27;Boolean&#x27;**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

