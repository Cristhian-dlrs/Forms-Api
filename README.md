# FormsApp_Api

## Download the client from [**FormsClient**](https://github.com/Cristhian-dlrs/Forms-app-client)

## Documentation for API Endpoints

All URIs are relative to _/_

| Class                       | Method                                                                           | HTTP request                            | Description |
| --------------------------- | -------------------------------------------------------------------------------- | --------------------------------------- | ----------- |
| _FormsAppapi.AccountApi_    | [**apiAccountLoginPost**](docs/AccountApi.md#apiAccountLoginPost)                | **POST** /api/Account/login             |
| _FormsAppapi.AccountApi_    | [**apiAccountRegisterPost**](docs/AccountApi.md#apiAccountRegisterPost)          | **POST** /api/Account/register          |
| _FormsAppapi.AnswerApi_     | [**apiAnswerPost**](docs/AnswerApi.md#apiAnswerPost)                             | **POST** /api/Answer                    |
| _FormsAppapi.AnswerApi_     | [**apiAnswerQuesitonIdGet**](docs/AnswerApi.md#apiAnswerQuesitonIdGet)           | **GET** /api/Answer/{quesitonId}        |
| _FormsAppapi.FormApi_       | [**apiFormGetAllUserIdGet**](docs/FormApi.md#apiFormGetAllUserIdGet)             | **GET** /api/Form/getAll/{userId}       |
| _FormsAppapi.FormApi_       | [**apiFormGetWithQuestionsIdGet**](docs/FormApi.md#apiFormGetWithQuestionsIdGet) | **GET** /api/Form/getWithQuestions/{id} |
| _FormsAppapi.FormApi_       | [**apiFormIdDelete**](docs/FormApi.md#apiFormIdDelete)                           | **DELETE** /api/Form/{id}               |
| _FormsAppapi.FormApi_       | [**apiFormIdGet**](docs/FormApi.md#apiFormIdGet)                                 | **GET** /api/Form/{id}                  |
| _FormsAppapi.FormApi_       | [**apiFormPost**](docs/FormApi.md#apiFormPost)                                   | **POST** /api/Form                      |
| _FormsAppapi.FormApi_       | [**apiFormPut**](docs/FormApi.md#apiFormPut)                                     | **PUT** /api/Form                       |
| _FormsAppapi.QuestionApi_   | [**apiQuestionIdDelete**](docs/QuestionApi.md#apiQuestionIdDelete)               | **DELETE** /api/Question/{id}           |
| _FormsAppapi.QuestionApi_   | [**apiQuestionPost**](docs/QuestionApi.md#apiQuestionPost)                       | **POST** /api/Question                  |
| _FormsAppapi.QuestionApi_   | [**apiQuestionPut**](docs/QuestionApi.md#apiQuestionPut)                         | **PUT** /api/Question                   |
| _FormsAppapi.RespondantApi_ | [**apiRespondantFormIdGet**](docs/RespondantApi.md#apiRespondantFormIdGet)       | **GET** /api/Respondant/{formId}        |
| _FormsAppapi.RespondantApi_ | [**apiRespondantPost**](docs/RespondantApi.md#apiRespondantPost)                 | **POST** /api/Respondant                |

## Documentation for Models

-   [FormsAppapi.AccountLoginBody](docs/AccountLoginBody.md)
-   [FormsAppapi.AccountRegisterBody](docs/AccountRegisterBody.md)
-   [FormsAppapi.AnswerDto](docs/AnswerDto.md)
-   [FormsAppapi.CreateAnswerDto](docs/CreateAnswerDto.md)
-   [FormsAppapi.CreateFormDto](docs/CreateFormDto.md)
-   [FormsAppapi.CreateQuesitonDto](docs/CreateQuesitonDto.md)
-   [FormsAppapi.CreateRespondantDto](docs/CreateRespondantDto.md)
-   [FormsAppapi.FormDto](docs/FormDto.md)
-   [FormsAppapi.ProblemDetails](docs/ProblemDetails.md)
-   [FormsAppapi.QuestionDto](docs/QuestionDto.md)
-   [FormsAppapi.RespondantDto](docs/RespondantDto.md)
-   [FormsAppapi.UpdateFormDto](docs/UpdateFormDto.md)
-   [FormsAppapi.UpdateQuestonDto](docs/UpdateQuestonDto.md)
-   [FormsAppapi.UserDto](docs/UserDto.md)

## Documentation for Authorization

All endpoints do not require authorization.
