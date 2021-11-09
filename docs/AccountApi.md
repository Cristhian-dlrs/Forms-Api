# FormsAppapi.AccountApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apiAccountLoginPost**](AccountApi.md#apiAccountLoginPost) | **POST** /api/Account/login | 
[**apiAccountRegisterPost**](AccountApi.md#apiAccountRegisterPost) | **POST** /api/Account/register | 

<a name="apiAccountLoginPost"></a>
# **apiAccountLoginPost**
> UserDto apiAccountLoginPost(opts)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.AccountApi();
let opts = { 
  'email': "email_example", // String | 
  'password': "password_example" // String | 
};
apiInstance.apiAccountLoginPost(opts, (error, data, response) => {
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
 **email** | **String**|  | [optional] 
 **password** | **String**|  | [optional] 

### Return type

[**UserDto**](UserDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

<a name="apiAccountRegisterPost"></a>
# **apiAccountRegisterPost**
> UserDto apiAccountRegisterPost(opts)



### Example
```javascript
import {FormsAppapi} from 'forms_appapi';

let apiInstance = new FormsAppapi.AccountApi();
let opts = { 
  'email': "email_example", // String | 
  'password': "password_example" // String | 
};
apiInstance.apiAccountRegisterPost(opts, (error, data, response) => {
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
 **email** | **String**|  | [optional] 
 **password** | **String**|  | [optional] 

### Return type

[**UserDto**](UserDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

