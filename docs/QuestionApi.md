# FormsAppapi.QuestionApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiQuestionIdDelete**](QuestionApi.md#apiQuestionIdDelete) | **DELETE** /api/Question/{id} | 
[**apiQuestionPost**](QuestionApi.md#apiQuestionPost) | **POST** /api/Question | 
[**apiQuestionPut**](QuestionApi.md#apiQuestionPut) | **PUT** /api/Question | 

<a name="apiQuestionIdDelete"></a>
# **apiQuestionIdDelete**
> &#x27;Boolean&#x27; apiQuestionIdDelete(id)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.QuestionApi();
let id = 56; // Number | 

apiInstance.apiQuestionIdDelete(id, (error, data, response) => {
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

<a name="apiQuestionPost"></a>
# **apiQuestionPost**
> QuestionDto apiQuestionPost(opts)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.QuestionApi();
let opts = { 
  'body': new FormsAppapi.CreateQuesitonDto() // CreateQuesitonDto | 
};
apiInstance.apiQuestionPost(opts, (error, data, response) => {
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
 **body** | [**CreateQuesitonDto**](CreateQuesitonDto.md)|  | [optional] 

### Return type

[**QuestionDto**](QuestionDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

<a name="apiQuestionPut"></a>
# **apiQuestionPut**
> &#x27;Boolean&#x27; apiQuestionPut(opts)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.QuestionApi();
let opts = { 
  'body': new FormsAppapi.UpdateQuestonDto() // UpdateQuestonDto | 
};
apiInstance.apiQuestionPut(opts, (error, data, response) => {
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
 **body** | [**UpdateQuestonDto**](UpdateQuestonDto.md)|  | [optional] 

### Return type

**&#x27;Boolean&#x27;**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

