### TavMobile - REST API template following Domain Driven Design and Clean Architecture.


- [Star pls ⭐!](#star-pls-)
- [Overview](#overview)
- [Usage](#usage)
- [API Definition](#api-definition)
 - [Create Section](#create-section)
    - [Create Section Request](#create-section-request)
    - [Create Section Response](#create-section-response)
 - [Get All Section](#get-all-section)
    - [Get All Section Request](#get-all-section-request)
    - [Get All Section Response](#get-all-section-response)
- [Disclaimer](#disclaimer)
- [License](#license)



# Star pls ⭐!
Liked it? Hit that star button

# Overview

 Creating and Reading operations on Sections aggregate.

 # Usage

`git clone https://github.com/smh53/TavMobile` && `dotnet run --project .\src\WebApi` in the folder that has `TavMobile.sln`

# API Definition




## Create Section


### Create Section Request

```js
POST /section
```

```json
{
    "name": "Android",
    "description": "Phones that have Android OS",
    "no": "101",
}
```

### Create Section Response

```js
200 OK
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Android",
    "description": "Phones that have Android OS",
    "no": "101",
}
```

## Get All Section

### Get All Section Request

```js
GET /section
```

### Get All Section Response

```js
200 Ok
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Android",
    "description": "Phones that have Android OS",
    "no": "101",

    "id": "00000000-0000-0000-0000-000000000001",
    "name": "IOS",
    "description": "Phones that have IOS OS",
    "no": "202",
    
}
```

# Disclaimer

This project is created for educational purposes. The source code is licensed under the MIT license.

# License

This project is licensed under the terms of the [MIT](https://github.com/smh53/TavMobile/blob/master/LICENSE.txt) license.


