# Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (WordpressV2APIPCL.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Wordpress%20v2%20API-CSharp&workspaceName=WordpressV2APIPCL&projectName=WordpressV2API.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the WordpressV2APIPCL library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Wordpress%20v2%20API-CSharp&workspaceName=WordpressV2APIPCL&projectName=WordpressV2API.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Wordpress%20v2%20API-CSharp&workspaceName=WordpressV2APIPCL&projectName=WordpressV2API.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Wordpress%20v2%20API-CSharp&workspaceName=WordpressV2APIPCL&projectName=WordpressV2API.PCL)

### 3. Add reference of the library project

In order to use the WordpressV2APIPCL library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Wordpress%20v2%20API-CSharp&workspaceName=WordpressV2APIPCL&projectName=WordpressV2API.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` WordpressV2API.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```WordpressV2API.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Wordpress%20v2%20API-CSharp&workspaceName=WordpressV2APIPCL&projectName=WordpressV2API.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Wordpress%20v2%20API-CSharp&workspaceName=WordpressV2APIPCL&projectName=WordpressV2API.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | The OAuth 2.0 access token to be set before API calls |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthAccessToken = "oAuthAccessToken"; // The OAuth 2.0 access token to be set before API calls

WordpressV2APIPCLClient client = new WordpressV2APIPCLClient(oAuthAccessToken);
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [APIController](#api_controller)

### <a name="api_controller"></a>![Class: ](https://apidocs.io/img/class.png "WordpressV2API.PCL.Controllers.APIController") APIController

#### Get singleton instance

The singleton instance of the ``` APIController ``` class can be accessed from the API Client.

```csharp
APIController client = client.Client;
```

#### <a name="get_statuses"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetStatuses") GetStatuses

> *Tags:*  ``` Skips Authentication ``` 

> List Status


```csharp
Task<List<Models.Status3>> GetStatuses(Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
var context = Models.ContextEnum?Helper.ParseString("view");

List<Models.Status3> result = await client.GetStatuses(context);

```


#### <a name="get_types"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetTypes") GetTypes

> *Tags:*  ``` Skips Authentication ``` 

> List Type


```csharp
Task<List<Models.Type>> GetTypes(Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
var context = Models.ContextEnum?Helper.ParseString("view");

List<Models.Type> result = await client.GetTypes(context);

```


#### <a name="get_posts_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetPostsById") GetPostsById

> *Tags:*  ``` Skips Authentication ``` 

> Get Single Post


```csharp
Task<Models.Post> GetPostsById(string id, Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
string id = "id";
var context = Models.ContextEnum?Helper.ParseString("view");

Models.Post result = await client.GetPostsById(id, context);

```


#### <a name="get_posts_revisions_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetPostsRevisionsById") GetPostsRevisionsById

> *Tags:*  ``` Skips Authentication ``` 

> Get post revisions


```csharp
Task<List<Models.Revision>> GetPostsRevisionsById(string id, Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
string id = "id";
var context = Models.ContextEnum?Helper.ParseString("view");

List<Models.Revision> result = await client.GetPostsRevisionsById(id, context);

```


#### <a name="delete_posts_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.DeletePostsById") DeletePostsById

> Delete Single Post


```csharp
Task DeletePostsById(string id, bool? force = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| force |  ``` Optional ```  | Whether to bypass trash and force deletion. |


#### Example Usage

```csharp
string id = "id";
bool? force = true;

await client.DeletePostsById(id, force);

```


#### <a name="delete_posts_revisions_by_id_and_revisionid"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.DeletePostsRevisionsByIdAndRevisionid") DeletePostsRevisionsByIdAndRevisionid

> *Tags:*  ``` Skips Authentication ``` 

> Delete single post revisions


```csharp
Task DeletePostsRevisionsByIdAndRevisionid(string id, string revisionid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| revisionid |  ``` Required ```  | Id of revision |


#### Example Usage

```csharp
string id = "id";
string revisionid = "revisionid";

await client.DeletePostsRevisionsByIdAndRevisionid(id, revisionid);

```


#### <a name="get_posts_revisions_by_id_and_revisionid"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetPostsRevisionsByIdAndRevisionid") GetPostsRevisionsByIdAndRevisionid

> *Tags:*  ``` Skips Authentication ``` 

> Get single post revisions


```csharp
Task<Models.Revision> GetPostsRevisionsByIdAndRevisionid(string id, string revisionid, Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| revisionid |  ``` Required ```  | Id of revision |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
string id = "id";
string revisionid = "revisionid";
var context = Models.ContextEnum?Helper.ParseString("view");

Models.Revision result = await client.GetPostsRevisionsByIdAndRevisionid(id, revisionid, context);

```


#### <a name="get_categories_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetCategoriesById") GetCategoriesById

> *Tags:*  ``` Skips Authentication ``` 

> Get Single Category


```csharp
Task<Models.Category> GetCategoriesById(string id, Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
string id = "id";
var context = Models.ContextEnum?Helper.ParseString("view");

Models.Category result = await client.GetCategoriesById(id, context);

```


#### <a name="create_categories"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.CreateCategories") CreateCategories

> Create Category


```csharp
Task<Models.Category> CreateCategories(
        string name,
        string description = null,
        string slug = null,
        int? parent = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Required ```  | HTML title for the resource. |
| description |  ``` Optional ```  | The description for the resource |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| parent |  ``` Optional ```  | The id for the parent of the object. |


#### Example Usage

```csharp
string name = "name";
string description = "description";
string slug = "slug";
int? parent = 138;

Models.Category result = await client.CreateCategories(name, description, slug, parent);

```


#### <a name="get_taxonomies_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetTaxonomiesById") GetTaxonomiesById

> *Tags:*  ``` Skips Authentication ``` 

> Get Single Taxonomy


```csharp
Task<Models.Taxonomy> GetTaxonomiesById(string id, Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
string id = "id";
var context = Models.ContextEnum?Helper.ParseString("view");

Models.Taxonomy result = await client.GetTaxonomiesById(id, context);

```


#### <a name="get_taxonomies"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetTaxonomies") GetTaxonomies

> *Tags:*  ``` Skips Authentication ``` 

> List Taxonomy


```csharp
Task<List<Models.Taxonomy>> GetTaxonomies(Models.ContextEnum? context = null, string type = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |
| type |  ``` Optional ```  | Limit result set to comments assigned a specific type. Requires authorization. Default comment |


#### Example Usage

```csharp
var context = Models.ContextEnum?Helper.ParseString("view");
string type = "type";

List<Models.Taxonomy> result = await client.GetTaxonomies(context, type);

```


#### <a name="delete_comments_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.DeleteCommentsById") DeleteCommentsById

> Delete Single Comment


```csharp
Task DeleteCommentsById(string id, bool? force = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| force |  ``` Optional ```  | Whether to bypass trash and force deletion. |


#### Example Usage

```csharp
string id = "id";
bool? force = true;

await client.DeleteCommentsById(id, force);

```


#### <a name="get_comments_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetCommentsById") GetCommentsById

> *Tags:*  ``` Skips Authentication ``` 

> Get Single Comment


```csharp
Task<Models.Comment> GetCommentsById(string id, Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
string id = "id";
var context = Models.ContextEnum?Helper.ParseString("view");

Models.Comment result = await client.GetCommentsById(id, context);

```


#### <a name="get_statuses_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetStatusesById") GetStatusesById

> *Tags:*  ``` Skips Authentication ``` 

> Get Single Status


```csharp
Task<Models.Status3> GetStatusesById(string id, Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
string id = "id";
var context = Models.ContextEnum?Helper.ParseString("view");

Models.Status3 result = await client.GetStatusesById(id, context);

```


#### <a name="get_types_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetTypesById") GetTypesById

> *Tags:*  ``` Skips Authentication ``` 

> Get Single Type


```csharp
Task<Models.Type> GetTypesById(string id, Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
string id = "id";
var context = Models.ContextEnum?Helper.ParseString("view");

Models.Type result = await client.GetTypesById(id, context);

```


#### <a name="delete_media_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.DeleteMediaById") DeleteMediaById

> Delete Single Media


```csharp
Task DeleteMediaById(string id, bool? force = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| force |  ``` Optional ```  | Whether to bypass trash and force deletion. |


#### Example Usage

```csharp
string id = "id";
bool? force = true;

await client.DeleteMediaById(id, force);

```


#### <a name="get_media_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetMediaById") GetMediaById

> *Tags:*  ``` Skips Authentication ``` 

> Get Single Media


```csharp
Task<Models.Media> GetMediaById(string id, Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
string id = "id";
var context = Models.ContextEnum?Helper.ParseString("view");

Models.Media result = await client.GetMediaById(id, context);

```


#### <a name="delete_pages_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.DeletePagesById") DeletePagesById

> Delete Single Page


```csharp
Task DeletePagesById(string id, bool? force = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| force |  ``` Optional ```  | Whether to bypass trash and force deletion. |


#### Example Usage

```csharp
string id = "id";
bool? force = true;

await client.DeletePagesById(id, force);

```


#### <a name="get_pages_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetPagesById") GetPagesById

> *Tags:*  ``` Skips Authentication ``` 

> Get Single Page


```csharp
Task<Models.Page> GetPagesById(string id, Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
string id = "id";
var context = Models.ContextEnum?Helper.ParseString("view");

Models.Page result = await client.GetPagesById(id, context);

```


#### <a name="delete_users_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.DeleteUsersById") DeleteUsersById

> Delete Single User


```csharp
Task DeleteUsersById(string id, bool? force = null, string reassign = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| force |  ``` Optional ```  | Whether to bypass trash and force deletion. |
| reassign |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
string id = "id";
bool? force = true;
string reassign = "reassign";

await client.DeleteUsersById(id, force, reassign);

```


#### <a name="get_users_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetUsersById") GetUsersById

> *Tags:*  ``` Skips Authentication ``` 

> Get Single User


```csharp
Task<Models.User> GetUsersById(string id, Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
string id = "id";
var context = Models.ContextEnum?Helper.ParseString("view");

Models.User result = await client.GetUsersById(id, context);

```


#### <a name="delete_tags_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.DeleteTagsById") DeleteTagsById

> Delete Single Tag


```csharp
Task DeleteTagsById(string id, bool? force = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| force |  ``` Optional ```  | Whether to bypass trash and force deletion. |


#### Example Usage

```csharp
string id = "id";
bool? force = true;

await client.DeleteTagsById(id, force);

```


#### <a name="create_tags_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.CreateTagsById") CreateTagsById

> Update Single Tag


```csharp
Task<Models.Tag> CreateTagsById(
        string id,
        string name,
        string description = null,
        string slug = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| name |  ``` Required ```  | HTML title for the resource. |
| description |  ``` Optional ```  | The description for the resource |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |


#### Example Usage

```csharp
string id = "id";
string name = "name";
string description = "description";
string slug = "slug";

Models.Tag result = await client.CreateTagsById(id, name, description, slug);

```


#### <a name="get_tags_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetTagsById") GetTagsById

> *Tags:*  ``` Skips Authentication ``` 

> Get Single Tag


```csharp
Task<Models.Tag> GetTagsById(string id, Models.ContextEnum? context = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |


#### Example Usage

```csharp
string id = "id";
var context = Models.ContextEnum?Helper.ParseString("view");

Models.Tag result = await client.GetTagsById(id, context);

```


#### <a name="create_tags"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.CreateTags") CreateTags

> Create Tag


```csharp
Task<Models.Tag> CreateTags(string name, string description = null, string slug = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Required ```  | HTML title for the resource. |
| description |  ``` Optional ```  | The description for the resource |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |


#### Example Usage

```csharp
string name = "name";
string description = "description";
string slug = "slug";

Models.Tag result = await client.CreateTags(name, description, slug);

```


#### <a name="delete_categories_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.DeleteCategoriesById") DeleteCategoriesById

> Delete Single Category


```csharp
Task DeleteCategoriesById(string id, bool? force = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| force |  ``` Optional ```  | Whether to bypass trash and force deletion. |


#### Example Usage

```csharp
string id = "id";
bool? force = true;

await client.DeleteCategoriesById(id, force);

```


#### <a name="create_categories_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.CreateCategoriesById") CreateCategoriesById

> Update Single Category


```csharp
Task<Models.Category> CreateCategoriesById(
        string id,
        string name,
        string description = null,
        string slug = null,
        int? parent = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| name |  ``` Required ```  | HTML title for the resource. |
| description |  ``` Optional ```  | The description for the resource |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| parent |  ``` Optional ```  | The id for the parent of the object. |


#### Example Usage

```csharp
string id = "id";
string name = "name";
string description = "description";
string slug = "slug";
int? parent = 138;

Models.Category result = await client.CreateCategoriesById(id, name, description, slug, parent);

```


#### <a name="create_users_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.CreateUsersById") CreateUsersById

> Update Single User


```csharp
Task<Models.User> CreateUsersById(
        string id,
        string name,
        string username = null,
        string firstName = null,
        string lastName = null,
        string email = null,
        string url = null,
        string description = null,
        string nickname = null,
        string slug = null,
        List<string> roles = null,
        string password = null,
        List<string> capabilities = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| name |  ``` Required ```  | HTML title for the resource. |
| username |  ``` Optional ```  | The user name for the resource. |
| firstName |  ``` Optional ```  | The first name for the resource. |
| lastName |  ``` Optional ```  | The last name for the resource. |
| email |  ``` Optional ```  | Email of the resource. |
| url |  ``` Optional ```  | URL of the resource. |
| description |  ``` Optional ```  | The description for the resource |
| nickname |  ``` Optional ```  | The nickname for the resource. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| roles |  ``` Optional ```  ``` Collection ```  | Roles assigned to the resource. |
| password |  ``` Optional ```  | The A password to protect access to the post. |
| capabilities |  ``` Optional ```  ``` Collection ```  | All capabilities used by the resource. |


#### Example Usage

```csharp
string id = "id";
string name = "name";
string username = "username";
string firstName = "first_name";
string lastName = "last_name";
string email = "email";
string url = "url";
string description = "description";
string nickname = "nickname";
string slug = "slug";
List<string> roles = new List<string> { "roles" };
string password = "password";
List<string> capabilities = new List<string> { "capabilities" };

Models.User result = await client.CreateUsersById(id, name, username, firstName, lastName, email, url, description, nickname, slug, roles, password, capabilities);

```


#### <a name="create_users"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.CreateUsers") CreateUsers

> Create User


```csharp
Task<Models.User> CreateUsers(
        string name,
        string username = null,
        string firstName = null,
        string lastName = null,
        string email = null,
        string url = null,
        string description = null,
        string nickname = null,
        string slug = null,
        List<string> roles = null,
        string password = null,
        List<string> capabilities = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Required ```  | HTML title for the resource. |
| username |  ``` Optional ```  | The user name for the resource. |
| firstName |  ``` Optional ```  | The first name for the resource. |
| lastName |  ``` Optional ```  | The last name for the resource. |
| email |  ``` Optional ```  | Email of the resource. |
| url |  ``` Optional ```  | URL of the resource. |
| description |  ``` Optional ```  | The description for the resource |
| nickname |  ``` Optional ```  | The nickname for the resource. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| roles |  ``` Optional ```  ``` Collection ```  | Roles assigned to the resource. |
| password |  ``` Optional ```  | The A password to protect access to the post. |
| capabilities |  ``` Optional ```  ``` Collection ```  | All capabilities used by the resource. |


#### Example Usage

```csharp
string name = "name";
string username = "username";
string firstName = "first_name";
string lastName = "last_name";
string email = "email";
string url = "url";
string description = "description";
string nickname = "nickname";
string slug = "slug";
List<string> roles = new List<string> { "roles" };
string password = "password";
List<string> capabilities = new List<string> { "capabilities" };

Models.User result = await client.CreateUsers(name, username, firstName, lastName, email, url, description, nickname, slug, roles, password, capabilities);

```


#### <a name="get_users"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetUsers") GetUsers

> *Tags:*  ``` Skips Authentication ``` 

> List Tags


```csharp
Task<List<Models.User>> GetUsers(
        Models.ContextEnum? context = null,
        int? page = null,
        int? perPage = null,
        string search = null,
        string exclude = null,
        string include = null,
        Models.OrderEnum? order = null,
        Models.OrderbyEnum? morderby = null,
        List<string> roles = null,
        string slug = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |
| page |  ``` Optional ```  | Current page of the collection. Default 1 |
| perPage |  ``` Optional ```  | Maximum number of items to be returned in result set. Default 10 |
| search |  ``` Optional ```  | Limit results to those matching a string. |
| exclude |  ``` Optional ```  | Ensure result set excludes specific ids. |
| include |  ``` Optional ```  | Ensure result set includes specific ids. |
| order |  ``` Optional ```  | Order sort attribute ascending or descending. Default desc |
| morderby |  ``` Optional ```  | Sort collection by object attribute. Default date |
| roles |  ``` Optional ```  ``` Collection ```  | Roles assigned to the resource. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |


#### Example Usage

```csharp
var context = Models.ContextEnum?Helper.ParseString("view");
int? page = 138;
int? perPage = 138;
string search = "search";
string exclude = "exclude";
string include = "include";
var order = Models.OrderEnum?Helper.ParseString("desc");
var morderby = Models.OrderbyEnum?Helper.ParseString("date");
List<string> roles = new List<string> { "roles" };
string slug = "slug";

List<Models.User> result = await client.GetUsers(context, page, perPage, search, exclude, include, order, morderby, roles, slug);

```


#### <a name="get_tags"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetTags") GetTags

> *Tags:*  ``` Skips Authentication ``` 

> List Tags


```csharp
Task<List<Models.Tag>> GetTags(
        Models.ContextEnum? context = null,
        int? page = null,
        int? perPage = null,
        string search = null,
        string exclude = null,
        string include = null,
        Models.OrderEnum? order = null,
        Models.OrderbyEnum? morderby = null,
        string post = null,
        string slug = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |
| page |  ``` Optional ```  | Current page of the collection. Default 1 |
| perPage |  ``` Optional ```  | Maximum number of items to be returned in result set. Default 10 |
| search |  ``` Optional ```  | Limit results to those matching a string. |
| exclude |  ``` Optional ```  | Ensure result set excludes specific ids. |
| include |  ``` Optional ```  | Ensure result set includes specific ids. |
| order |  ``` Optional ```  | Order sort attribute ascending or descending. Default desc |
| morderby |  ``` Optional ```  | Sort collection by object attribute. Default date |
| post |  ``` Optional ```  | The id for the associated post of the resource. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |


#### Example Usage

```csharp
var context = Models.ContextEnum?Helper.ParseString("view");
int? page = 138;
int? perPage = 138;
string search = "search";
string exclude = "exclude";
string include = "include";
var order = Models.OrderEnum?Helper.ParseString("desc");
var morderby = Models.OrderbyEnum?Helper.ParseString("date");
string post = "post";
string slug = "slug";

List<Models.Tag> result = await client.GetTags(context, page, perPage, search, exclude, include, order, morderby, post, slug);

```


#### <a name="get_categories"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetCategories") GetCategories

> *Tags:*  ``` Skips Authentication ``` 

> List categories


```csharp
Task<List<Models.Category>> GetCategories(
        Models.ContextEnum? context = null,
        int? page = null,
        int? perPage = null,
        string search = null,
        bool? hideEmpty = null,
        string exclude = null,
        string include = null,
        Models.OrderEnum? order = null,
        Models.OrderbyEnum? morderby = null,
        int? parent = null,
        string post = null,
        string slug = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |
| page |  ``` Optional ```  | Current page of the collection. Default 1 |
| perPage |  ``` Optional ```  | Maximum number of items to be returned in result set. Default 10 |
| search |  ``` Optional ```  | Limit results to those matching a string. |
| hideEmpty |  ``` Optional ```  | Whether to hide resources not assigned to any posts. |
| exclude |  ``` Optional ```  | Ensure result set excludes specific ids. |
| include |  ``` Optional ```  | Ensure result set includes specific ids. |
| order |  ``` Optional ```  | Order sort attribute ascending or descending. Default desc |
| morderby |  ``` Optional ```  | Sort collection by object attribute. Default date |
| parent |  ``` Optional ```  | The id for the parent of the object. |
| post |  ``` Optional ```  | The id for the associated post of the resource. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |


#### Example Usage

```csharp
var context = Models.ContextEnum?Helper.ParseString("view");
int? page = 230;
int? perPage = 230;
string search = "search";
bool? hideEmpty = true;
string exclude = "exclude";
string include = "include";
var order = Models.OrderEnum?Helper.ParseString("desc");
var morderby = Models.OrderbyEnum?Helper.ParseString("date");
int? parent = 230;
string post = "post";
string slug = "slug";

List<Models.Category> result = await client.GetCategories(context, page, perPage, search, hideEmpty, exclude, include, order, morderby, parent, post, slug);

```


#### <a name="create_comments"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.CreateComments") CreateComments

> Create Comment


```csharp
Task<Models.Comment> CreateComments(
        DateTime? date = null,
        DateTime? dateGmt = null,
        string password = null,
        string slug = null,
        Models.StatusEnum? status = null,
        string title = null,
        string author = null,
        Models.CommentStatus34Enum? commentStatus = null,
        Models.PingStatus35Enum? pingStatus = null,
        string altText = null,
        string caption = null,
        string description = null,
        string post = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| date |  ``` Optional ```  | The date the object was published, in the site's timezone. |
| dateGmt |  ``` Optional ```  | The date the object was published, as GMT. |
| password |  ``` Optional ```  | The A password to protect access to the post. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| status |  ``` Optional ```  | Limit result set to posts assigned a specific status.Default publish |
| title |  ``` Optional ```  | The title for the object. |
| author |  ``` Optional ```  | Limit result set to posts assigned to specific authors. |
| commentStatus |  ``` Optional ```  | Whether or not comments are open on the object |
| pingStatus |  ``` Optional ```  | Whether or not the object can be pinged. |
| altText |  ``` Optional ```  | Alternative text to display when resource is not displayed. |
| caption |  ``` Optional ```  | The caption for the resource. |
| description |  ``` Optional ```  | The description for the resource |
| post |  ``` Optional ```  | The id for the associated post of the resource. |


#### Example Usage

```csharp
DateTime? date = DateTime.Now();
DateTime? dateGmt = DateTime.Now();
string password = "password";
string slug = "slug";
var status = Models.StatusEnum?Helper.ParseString("publish");
string title = "title";
string author = "author";
var commentStatus = Models.CommentStatus34Enum?Helper.ParseString("open");
var pingStatus = Models.PingStatus35Enum?Helper.ParseString("open");
string altText = "alt_text";
string caption = "caption";
string description = "description";
string post = "post";

Models.Comment result = await client.CreateComments(date, dateGmt, password, slug, status, title, author, commentStatus, pingStatus, altText, caption, description, post);

```


#### <a name="create_media"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.CreateMedia") CreateMedia

> Create Media


```csharp
Task<Models.Media> CreateMedia(
        DateTime? date = null,
        DateTime? dateGmt = null,
        string password = null,
        string slug = null,
        Models.StatusEnum? status = null,
        string title = null,
        string author = null,
        Models.CommentStatus34Enum? commentStatus = null,
        Models.PingStatus35Enum? pingStatus = null,
        string altText = null,
        string caption = null,
        string description = null,
        string post = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| date |  ``` Optional ```  | The date the object was published, in the site's timezone. |
| dateGmt |  ``` Optional ```  | The date the object was published, as GMT. |
| password |  ``` Optional ```  | The A password to protect access to the post. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| status |  ``` Optional ```  | Limit result set to posts assigned a specific status.Default publish |
| title |  ``` Optional ```  | The title for the object. |
| author |  ``` Optional ```  | Limit result set to posts assigned to specific authors. |
| commentStatus |  ``` Optional ```  | Whether or not comments are open on the object |
| pingStatus |  ``` Optional ```  | Whether or not the object can be pinged. |
| altText |  ``` Optional ```  | Alternative text to display when resource is not displayed. |
| caption |  ``` Optional ```  | The caption for the resource. |
| description |  ``` Optional ```  | The description for the resource |
| post |  ``` Optional ```  | The id for the associated post of the resource. |


#### Example Usage

```csharp
DateTime? date = DateTime.Now();
DateTime? dateGmt = DateTime.Now();
string password = "password";
string slug = "slug";
var status = Models.StatusEnum?Helper.ParseString("publish");
string title = "title";
string author = "author";
var commentStatus = Models.CommentStatus34Enum?Helper.ParseString("open");
var pingStatus = Models.PingStatus35Enum?Helper.ParseString("open");
string altText = "alt_text";
string caption = "caption";
string description = "description";
string post = "post";

Models.Media result = await client.CreateMedia(date, dateGmt, password, slug, status, title, author, commentStatus, pingStatus, altText, caption, description, post);

```


#### <a name="create_comments_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.CreateCommentsById") CreateCommentsById

> Update Single Comment


```csharp
Task<Models.Comment> CreateCommentsById(
        string id,
        DateTime? date = null,
        DateTime? dateGmt = null,
        string password = null,
        string slug = null,
        Models.StatusEnum? status = null,
        string title = null,
        string author = null,
        Models.CommentStatus34Enum? commentStatus = null,
        Models.PingStatus35Enum? pingStatus = null,
        string altText = null,
        string caption = null,
        string description = null,
        string post = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| date |  ``` Optional ```  | The date the object was published, in the site's timezone. |
| dateGmt |  ``` Optional ```  | The date the object was published, as GMT. |
| password |  ``` Optional ```  | The A password to protect access to the post. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| status |  ``` Optional ```  | Limit result set to posts assigned a specific status.Default publish |
| title |  ``` Optional ```  | The title for the object. |
| author |  ``` Optional ```  | Limit result set to posts assigned to specific authors. |
| commentStatus |  ``` Optional ```  | Whether or not comments are open on the object |
| pingStatus |  ``` Optional ```  | Whether or not the object can be pinged. |
| altText |  ``` Optional ```  | Alternative text to display when resource is not displayed. |
| caption |  ``` Optional ```  | The caption for the resource. |
| description |  ``` Optional ```  | The description for the resource |
| post |  ``` Optional ```  | The id for the associated post of the resource. |


#### Example Usage

```csharp
string id = "id";
DateTime? date = DateTime.Now();
DateTime? dateGmt = DateTime.Now();
string password = "password";
string slug = "slug";
var status = Models.StatusEnum?Helper.ParseString("publish");
string title = "title";
string author = "author";
var commentStatus = Models.CommentStatus34Enum?Helper.ParseString("open");
var pingStatus = Models.PingStatus35Enum?Helper.ParseString("open");
string altText = "alt_text";
string caption = "caption";
string description = "description";
string post = "post";

Models.Comment result = await client.CreateCommentsById(id, date, dateGmt, password, slug, status, title, author, commentStatus, pingStatus, altText, caption, description, post);

```


#### <a name="get_comments"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetComments") GetComments

> *Tags:*  ``` Skips Authentication ``` 

> List Comments


```csharp
Task<List<Models.Comment>> GetComments(
        Models.ContextEnum? context = null,
        int? page = null,
        int? perPage = null,
        string search = null,
        string after = null,
        string author = null,
        string authorExclude = null,
        string authorEmail = null,
        string before = null,
        string exclude = null,
        string include = null,
        string karma = null,
        string offset = null,
        Models.OrderEnum? order = null,
        Models.OrderbyEnum? morderby = null,
        int? parent = null,
        string parentExclude = null,
        string post = null,
        Models.StatusEnum? status = null,
        string type = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |
| page |  ``` Optional ```  | Current page of the collection. Default 1 |
| perPage |  ``` Optional ```  | Maximum number of items to be returned in result set. Default 10 |
| search |  ``` Optional ```  | Limit results to those matching a string. |
| after |  ``` Optional ```  | Limit response to resources published after a given ISO8601 compliant date. |
| author |  ``` Optional ```  | Limit result set to posts assigned to specific authors. |
| authorExclude |  ``` Optional ```  | Ensure result set excludes posts assigned to specific authors. |
| authorEmail |  ``` Optional ```  | Limit result set to that from a specific author email. Requires authorization. |
| before |  ``` Optional ```  | Limit response to resources published before a given ISO8601 compliant date. |
| exclude |  ``` Optional ```  | Ensure result set excludes specific ids. |
| include |  ``` Optional ```  | Ensure result set includes specific ids. |
| karma |  ``` Optional ```  | Limit result set to that of a particular comment karma. Requires authorization |
| offset |  ``` Optional ```  | Offset the result set by a specific number of items. |
| order |  ``` Optional ```  | Order sort attribute ascending or descending. Default desc |
| morderby |  ``` Optional ```  | Sort collection by object attribute. Default date |
| parent |  ``` Optional ```  | The id for the parent of the object. |
| parentExclude |  ``` Optional ```  | Ensure result set excludes specific ids. |
| post |  ``` Optional ```  | The id for the associated post of the resource. |
| status |  ``` Optional ```  | Limit result set to posts assigned a specific status.Default publish |
| type |  ``` Optional ```  | Limit result set to comments assigned a specific type. Requires authorization. Default comment |


#### Example Usage

```csharp
var context = Models.ContextEnum?Helper.ParseString("view");
int? page = 230;
int? perPage = 230;
string search = "search";
string after = "after";
string author = "author";
string authorExclude = "author_exclude";
string authorEmail = "author_email";
string before = "before";
string exclude = "exclude";
string include = "include";
string karma = "karma";
string offset = "offset";
var order = Models.OrderEnum?Helper.ParseString("desc");
var morderby = Models.OrderbyEnum?Helper.ParseString("date");
int? parent = 230;
string parentExclude = "parent_exclude";
string post = "post";
var status = Models.StatusEnum?Helper.ParseString("publish");
string type = "type";

List<Models.Comment> result = await client.GetComments(context, page, perPage, search, after, author, authorExclude, authorEmail, before, exclude, include, karma, offset, order, morderby, parent, parentExclude, post, status, type);

```


#### <a name="create_media_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.CreateMediaById") CreateMediaById

> Update Single Media


```csharp
Task<Models.Media> CreateMediaById(
        string id,
        DateTime? date = null,
        DateTime? dateGmt = null,
        string password = null,
        string slug = null,
        Models.StatusEnum? status = null,
        string title = null,
        string author = null,
        Models.CommentStatus34Enum? commentStatus = null,
        Models.PingStatus35Enum? pingStatus = null,
        string altText = null,
        string caption = null,
        string description = null,
        string post = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| date |  ``` Optional ```  | The date the object was published, in the site's timezone. |
| dateGmt |  ``` Optional ```  | The date the object was published, as GMT. |
| password |  ``` Optional ```  | The A password to protect access to the post. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| status |  ``` Optional ```  | Limit result set to posts assigned a specific status.Default publish |
| title |  ``` Optional ```  | The title for the object. |
| author |  ``` Optional ```  | Limit result set to posts assigned to specific authors. |
| commentStatus |  ``` Optional ```  | Whether or not comments are open on the object |
| pingStatus |  ``` Optional ```  | Whether or not the object can be pinged. |
| altText |  ``` Optional ```  | Alternative text to display when resource is not displayed. |
| caption |  ``` Optional ```  | The caption for the resource. |
| description |  ``` Optional ```  | The description for the resource |
| post |  ``` Optional ```  | The id for the associated post of the resource. |


#### Example Usage

```csharp
string id = "id";
DateTime? date = DateTime.Now();
DateTime? dateGmt = DateTime.Now();
string password = "password";
string slug = "slug";
var status = Models.StatusEnum?Helper.ParseString("publish");
string title = "title";
string author = "author";
var commentStatus = Models.CommentStatus34Enum?Helper.ParseString("open");
var pingStatus = Models.PingStatus35Enum?Helper.ParseString("open");
string altText = "alt_text";
string caption = "caption";
string description = "description";
string post = "post";

Models.Media result = await client.CreateMediaById(id, date, dateGmt, password, slug, status, title, author, commentStatus, pingStatus, altText, caption, description, post);

```


#### <a name="get_media"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetMedia") GetMedia

> *Tags:*  ``` Skips Authentication ``` 

> List Media


```csharp
Task<List<Models.Media>> GetMedia(
        Models.ContextEnum? context = null,
        int? page = null,
        int? perPage = null,
        string search = null,
        string after = null,
        string author = null,
        string authorExclude = null,
        string before = null,
        string exclude = null,
        string include = null,
        string offset = null,
        Models.OrderEnum? order = null,
        Models.OrderbyEnum? morderby = null,
        int? parent = null,
        string parentExclude = null,
        string slug = null,
        Models.StatusEnum? status = null,
        string filter = null,
        Models.MediaType58Enum? mediaType = null,
        string mimeType = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |
| page |  ``` Optional ```  | Current page of the collection. Default 1 |
| perPage |  ``` Optional ```  | Maximum number of items to be returned in result set. Default 10 |
| search |  ``` Optional ```  | Limit results to those matching a string. |
| after |  ``` Optional ```  | Limit response to resources published after a given ISO8601 compliant date. |
| author |  ``` Optional ```  | Limit result set to posts assigned to specific authors. |
| authorExclude |  ``` Optional ```  | Ensure result set excludes posts assigned to specific authors. |
| before |  ``` Optional ```  | Limit response to resources published before a given ISO8601 compliant date. |
| exclude |  ``` Optional ```  | Ensure result set excludes specific ids. |
| include |  ``` Optional ```  | Ensure result set includes specific ids. |
| offset |  ``` Optional ```  | Offset the result set by a specific number of items. |
| order |  ``` Optional ```  | Order sort attribute ascending or descending. Default desc |
| morderby |  ``` Optional ```  | Sort collection by object attribute. Default date |
| parent |  ``` Optional ```  | The id for the parent of the object. |
| parentExclude |  ``` Optional ```  | Ensure result set excludes specific ids. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| status |  ``` Optional ```  | Limit result set to posts assigned a specific status.Default publish |
| filter |  ``` Optional ```  | Use WP Query arguments to modify the response; private query vars require appropriate authorization. |
| mediaType |  ``` Optional ```  | Type of resource. |
| mimeType |  ``` Optional ```  | Alternative text to display when resource is not displayed. |


#### Example Usage

```csharp
var context = Models.ContextEnum?Helper.ParseString("view");
int? page = 230;
int? perPage = 230;
string search = "search";
string after = "after";
string author = "author";
string authorExclude = "author_exclude";
string before = "before";
string exclude = "exclude";
string include = "include";
string offset = "offset";
var order = Models.OrderEnum?Helper.ParseString("desc");
var morderby = Models.OrderbyEnum?Helper.ParseString("date");
int? parent = 230;
string parentExclude = "parent_exclude";
string slug = "slug";
var status = Models.StatusEnum?Helper.ParseString("publish");
string filter = "filter";
var mediaType = Models.MediaType58Enum?Helper.ParseString("file");
string mimeType = "mime_type";

List<Models.Media> result = await client.GetMedia(context, page, perPage, search, after, author, authorExclude, before, exclude, include, offset, order, morderby, parent, parentExclude, slug, status, filter, mediaType, mimeType);

```


#### <a name="create_pages_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.CreatePagesById") CreatePagesById

> Update Single Page


```csharp
Task<Models.Page> CreatePagesById(
        string id,
        DateTime? date = null,
        DateTime? dateGmt = null,
        string password = null,
        string slug = null,
        Models.StatusEnum? status = null,
        int? parent = null,
        string title = null,
        string content = null,
        string author = null,
        string excerpt = null,
        string featuredMedia = null,
        Models.CommentStatus34Enum? commentStatus = null,
        Models.PingStatus35Enum? pingStatus = null,
        int? menuOrder = null,
        int? template = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| date |  ``` Optional ```  | The date the object was published, in the site's timezone. |
| dateGmt |  ``` Optional ```  | The date the object was published, as GMT. |
| password |  ``` Optional ```  | The A password to protect access to the post. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| status |  ``` Optional ```  | Limit result set to posts assigned a specific status.Default publish |
| parent |  ``` Optional ```  | The id for the parent of the object. |
| title |  ``` Optional ```  | The title for the object. |
| content |  ``` Optional ```  | The content for the object. |
| author |  ``` Optional ```  | Limit result set to posts assigned to specific authors. |
| excerpt |  ``` Optional ```  | The excerpt for the object |
| featuredMedia |  ``` Optional ```  | The id of the featured media for the object. |
| commentStatus |  ``` Optional ```  | Whether or not comments are open on the object |
| pingStatus |  ``` Optional ```  | Whether or not the object can be pinged. |
| menuOrder |  ``` Optional ```  | The order of the object in relation to other object of its type. |
| template |  ``` Optional ```  | The theme file to use to display the object. |


#### Example Usage

```csharp
string id = "id";
DateTime? date = DateTime.Now();
DateTime? dateGmt = DateTime.Now();
string password = "password";
string slug = "slug";
var status = Models.StatusEnum?Helper.ParseString("publish");
int? parent = 230;
string title = "title";
string content = "content";
string author = "author";
string excerpt = "excerpt";
string featuredMedia = "featured_media";
var commentStatus = Models.CommentStatus34Enum?Helper.ParseString("open");
var pingStatus = Models.PingStatus35Enum?Helper.ParseString("open");
int? menuOrder = 230;
int? template = 230;

Models.Page result = await client.CreatePagesById(id, date, dateGmt, password, slug, status, parent, title, content, author, excerpt, featuredMedia, commentStatus, pingStatus, menuOrder, template);

```


#### <a name="create_pages"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.CreatePages") CreatePages

> Create Page


```csharp
Task<Models.Page> CreatePages(
        DateTime? date = null,
        DateTime? dateGmt = null,
        string password = null,
        string slug = null,
        Models.StatusEnum? status = null,
        int? parent = null,
        string title = null,
        string content = null,
        string author = null,
        string excerpt = null,
        string featuredMedia = null,
        Models.CommentStatus34Enum? commentStatus = null,
        Models.PingStatus35Enum? pingStatus = null,
        int? menuOrder = null,
        int? template = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| date |  ``` Optional ```  | The date the object was published, in the site's timezone. |
| dateGmt |  ``` Optional ```  | The date the object was published, as GMT. |
| password |  ``` Optional ```  | The A password to protect access to the post. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| status |  ``` Optional ```  | Limit result set to posts assigned a specific status.Default publish |
| parent |  ``` Optional ```  | The id for the parent of the object. |
| title |  ``` Optional ```  | The title for the object. |
| content |  ``` Optional ```  | The content for the object. |
| author |  ``` Optional ```  | Limit result set to posts assigned to specific authors. |
| excerpt |  ``` Optional ```  | The excerpt for the object |
| featuredMedia |  ``` Optional ```  | The id of the featured media for the object. |
| commentStatus |  ``` Optional ```  | Whether or not comments are open on the object |
| pingStatus |  ``` Optional ```  | Whether or not the object can be pinged. |
| menuOrder |  ``` Optional ```  | The order of the object in relation to other object of its type. |
| template |  ``` Optional ```  | The theme file to use to display the object. |


#### Example Usage

```csharp
DateTime? date = DateTime.Now();
DateTime? dateGmt = DateTime.Now();
string password = "password";
string slug = "slug";
var status = Models.StatusEnum?Helper.ParseString("publish");
int? parent = 230;
string title = "title";
string content = "content";
string author = "author";
string excerpt = "excerpt";
string featuredMedia = "featured_media";
var commentStatus = Models.CommentStatus34Enum?Helper.ParseString("open");
var pingStatus = Models.PingStatus35Enum?Helper.ParseString("open");
int? menuOrder = 230;
int? template = 230;

Models.Page result = await client.CreatePages(date, dateGmt, password, slug, status, parent, title, content, author, excerpt, featuredMedia, commentStatus, pingStatus, menuOrder, template);

```


#### <a name="get_pages"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetPages") GetPages

> *Tags:*  ``` Skips Authentication ``` 

> List Pages


```csharp
Task<List<Models.Page>> GetPages(
        Models.ContextEnum? context = null,
        int? page = null,
        int? perPage = null,
        string search = null,
        string after = null,
        string author = null,
        string authorExclude = null,
        string before = null,
        string exclude = null,
        string include = null,
        int? menuOrder = null,
        string offset = null,
        Models.OrderEnum? order = null,
        Models.OrderbyEnum? morderby = null,
        int? parent = null,
        string parentExclude = null,
        string slug = null,
        Models.StatusEnum? status = null,
        string filter = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |
| page |  ``` Optional ```  | Current page of the collection. Default 1 |
| perPage |  ``` Optional ```  | Maximum number of items to be returned in result set. Default 10 |
| search |  ``` Optional ```  | Limit results to those matching a string. |
| after |  ``` Optional ```  | Limit response to resources published after a given ISO8601 compliant date. |
| author |  ``` Optional ```  | Limit result set to posts assigned to specific authors. |
| authorExclude |  ``` Optional ```  | Ensure result set excludes posts assigned to specific authors. |
| before |  ``` Optional ```  | Limit response to resources published before a given ISO8601 compliant date. |
| exclude |  ``` Optional ```  | Ensure result set excludes specific ids. |
| include |  ``` Optional ```  | Ensure result set includes specific ids. |
| menuOrder |  ``` Optional ```  | The order of the object in relation to other object of its type. |
| offset |  ``` Optional ```  | Offset the result set by a specific number of items. |
| order |  ``` Optional ```  | Order sort attribute ascending or descending. Default desc |
| morderby |  ``` Optional ```  | Sort collection by object attribute. Default date |
| parent |  ``` Optional ```  | The id for the parent of the object. |
| parentExclude |  ``` Optional ```  | Ensure result set excludes specific ids. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| status |  ``` Optional ```  | Limit result set to posts assigned a specific status.Default publish |
| filter |  ``` Optional ```  | Use WP Query arguments to modify the response; private query vars require appropriate authorization. |


#### Example Usage

```csharp
var context = Models.ContextEnum?Helper.ParseString("view");
int? page = 230;
int? perPage = 230;
string search = "search";
string after = "after";
string author = "author";
string authorExclude = "author_exclude";
string before = "before";
string exclude = "exclude";
string include = "include";
int? menuOrder = 230;
string offset = "offset";
var order = Models.OrderEnum?Helper.ParseString("desc");
var morderby = Models.OrderbyEnum?Helper.ParseString("date");
int? parent = 230;
string parentExclude = "parent_exclude";
string slug = "slug";
var status = Models.StatusEnum?Helper.ParseString("publish");
string filter = "filter";

List<Models.Page> result = await client.GetPages(context, page, perPage, search, after, author, authorExclude, before, exclude, include, menuOrder, offset, order, morderby, parent, parentExclude, slug, status, filter);

```


#### <a name="posts_by_id"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.PostsById") PostsById

> Update Single Post


```csharp
Task<Models.Post> PostsById(
        string id,
        Models.ContextEnum? context = null,
        int? page = null,
        int? perPage = null,
        string search = null,
        string after = null,
        string author = null,
        string authorExclude = null,
        string before = null,
        string exclude = null,
        string include = null,
        string offset = null,
        Models.OrderEnum? order = null,
        Models.OrderbyEnum? morderby = null,
        string slug = null,
        Models.StatusEnum? status = null,
        string filter = null,
        List<string> categories = null,
        List<string> tags = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| id |  ``` Required ```  | Id of object |
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |
| page |  ``` Optional ```  | Current page of the collection. Default 1 |
| perPage |  ``` Optional ```  | Maximum number of items to be returned in result set. Default 10 |
| search |  ``` Optional ```  | Limit results to those matching a string. |
| after |  ``` Optional ```  | Limit response to resources published after a given ISO8601 compliant date. |
| author |  ``` Optional ```  | Limit result set to posts assigned to specific authors. |
| authorExclude |  ``` Optional ```  | Ensure result set excludes posts assigned to specific authors. |
| before |  ``` Optional ```  | Limit response to resources published before a given ISO8601 compliant date. |
| exclude |  ``` Optional ```  | Ensure result set excludes specific ids. |
| include |  ``` Optional ```  | Ensure result set includes specific ids. |
| offset |  ``` Optional ```  | Offset the result set by a specific number of items. |
| order |  ``` Optional ```  | Order sort attribute ascending or descending. Default desc |
| morderby |  ``` Optional ```  | Sort collection by object attribute. Default date |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| status |  ``` Optional ```  | Limit result set to posts assigned a specific status.Default publish |
| filter |  ``` Optional ```  | Use WP Query arguments to modify the response; private query vars require appropriate authorization. |
| categories |  ``` Optional ```  ``` Collection ```  | Limit result set to all items that have the specified term assigned in the categories taxonomy. |
| tags |  ``` Optional ```  ``` Collection ```  | Limit result set to all items that have the specified term assigned in the tags taxonomy. |


#### Example Usage

```csharp
string id = "id";
var context = Models.ContextEnum?Helper.ParseString("view");
int? page = 230;
int? perPage = 230;
string search = "search";
string after = "after";
string author = "author";
string authorExclude = "author_exclude";
string before = "before";
string exclude = "exclude";
string include = "include";
string offset = "offset";
var order = Models.OrderEnum?Helper.ParseString("desc");
var morderby = Models.OrderbyEnum?Helper.ParseString("date");
string slug = "slug";
var status = Models.StatusEnum?Helper.ParseString("publish");
string filter = "filter";
List<string> categories = new List<string> { "categories" };
List<string> tags = new List<string> { "tags" };

Models.Post result = await client.PostsById(id, context, page, perPage, search, after, author, authorExclude, before, exclude, include, offset, order, morderby, slug, status, filter, categories, tags);

```


#### <a name="posts"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.Posts") Posts

> Create Post


```csharp
Task<Models.Post> Posts(
        DateTime? date = null,
        DateTime? dateGmt = null,
        string password = null,
        string slug = null,
        Models.StatusEnum? status = null,
        string title = null,
        string content = null,
        string author = null,
        string excerpt = null,
        string featuredMedia = null,
        Models.CommentStatus34Enum? commentStatus = null,
        Models.PingStatus35Enum? pingStatus = null,
        bool? sticky = null,
        List<string> categories = null,
        List<string> tags = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| date |  ``` Optional ```  | The date the object was published, in the site's timezone. |
| dateGmt |  ``` Optional ```  | The date the object was published, as GMT. |
| password |  ``` Optional ```  | The A password to protect access to the post. |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| status |  ``` Optional ```  | Limit result set to posts assigned a specific status.Default publish |
| title |  ``` Optional ```  | The title for the object. |
| content |  ``` Optional ```  | The content for the object. |
| author |  ``` Optional ```  | Limit result set to posts assigned to specific authors. |
| excerpt |  ``` Optional ```  | The excerpt for the object |
| featuredMedia |  ``` Optional ```  | The id of the featured media for the object. |
| commentStatus |  ``` Optional ```  | Whether or not comments are open on the object |
| pingStatus |  ``` Optional ```  | Whether or not the object can be pinged. |
| sticky |  ``` Optional ```  | Whether or not the object should be treated as sticky. |
| categories |  ``` Optional ```  ``` Collection ```  | Limit result set to all items that have the specified term assigned in the categories taxonomy. |
| tags |  ``` Optional ```  ``` Collection ```  | Limit result set to all items that have the specified term assigned in the tags taxonomy. |


#### Example Usage

```csharp
DateTime? date = DateTime.Now();
DateTime? dateGmt = DateTime.Now();
string password = "password";
string slug = "slug";
var status = Models.StatusEnum?Helper.ParseString("publish");
string title = "title";
string content = "content";
string author = "author";
string excerpt = "excerpt";
string featuredMedia = "featured_media";
var commentStatus = Models.CommentStatus34Enum?Helper.ParseString("open");
var pingStatus = Models.PingStatus35Enum?Helper.ParseString("open");
bool? sticky = true;
List<string> categories = new List<string> { "categories" };
List<string> tags = new List<string> { "tags" };

Models.Post result = await client.Posts(date, dateGmt, password, slug, status, title, content, author, excerpt, featuredMedia, commentStatus, pingStatus, sticky, categories, tags);

```


#### <a name="get_posts"></a>![Method: ](https://apidocs.io/img/method.png "WordpressV2API.PCL.Controllers.APIController.GetPosts") GetPosts

> *Tags:*  ``` Skips Authentication ``` 

> List Posts


```csharp
Task<List<Models.Post>> GetPosts(
        Models.ContextEnum? context = null,
        int? page = null,
        int? perPage = null,
        string search = null,
        string after = null,
        string author = null,
        string authorExclude = null,
        string before = null,
        string exclude = null,
        string include = null,
        string offset = null,
        Models.OrderEnum? order = null,
        Models.OrderbyEnum? morderby = null,
        string slug = null,
        Models.StatusEnum? status = null,
        string filter = null,
        List<string> categories = null,
        List<string> tags = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| context |  ``` Optional ```  | Scope under which the request is made; determines fields present in response. |
| page |  ``` Optional ```  | Current page of the collection. Default 1 |
| perPage |  ``` Optional ```  | Maximum number of items to be returned in result set. Default 10 |
| search |  ``` Optional ```  | Limit results to those matching a string. |
| after |  ``` Optional ```  | Limit response to resources published after a given ISO8601 compliant date. |
| author |  ``` Optional ```  | Limit result set to posts assigned to specific authors. |
| authorExclude |  ``` Optional ```  | Ensure result set excludes posts assigned to specific authors. |
| before |  ``` Optional ```  | Limit response to resources published before a given ISO8601 compliant date. |
| exclude |  ``` Optional ```  | Ensure result set excludes specific ids. |
| include |  ``` Optional ```  | Ensure result set includes specific ids. |
| offset |  ``` Optional ```  | Offset the result set by a specific number of items. |
| order |  ``` Optional ```  | Order sort attribute ascending or descending. Default desc |
| morderby |  ``` Optional ```  | Sort collection by object attribute. Default date |
| slug |  ``` Optional ```  | Limit result set to posts with a specific slug. |
| status |  ``` Optional ```  | Limit result set to posts assigned a specific status.Default publish |
| filter |  ``` Optional ```  | Use WP Query arguments to modify the response; private query vars require appropriate authorization. |
| categories |  ``` Optional ```  ``` Collection ```  | Limit result set to all items that have the specified term assigned in the categories taxonomy. |
| tags |  ``` Optional ```  ``` Collection ```  | Limit result set to all items that have the specified term assigned in the tags taxonomy. |


#### Example Usage

```csharp
var context = Models.ContextEnum?Helper.ParseString("view");
int? page = 188;
int? perPage = 188;
string search = "search";
string after = "after";
string author = "author";
string authorExclude = "author_exclude";
string before = "before";
string exclude = "exclude";
string include = "include";
string offset = "offset";
var order = Models.OrderEnum?Helper.ParseString("desc");
var morderby = Models.OrderbyEnum?Helper.ParseString("date");
string slug = "slug";
var status = Models.StatusEnum?Helper.ParseString("publish");
string filter = "filter";
List<string> categories = new List<string> { "categories" };
List<string> tags = new List<string> { "tags" };

List<Models.Post> result = await client.GetPosts(context, page, perPage, search, after, author, authorExclude, before, exclude, include, offset, order, morderby, slug, status, filter, categories, tags);

```


[Back to List of Controllers](#list_of_controllers)



