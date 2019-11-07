# Google drive project CLI

This is a .net core command line project that use the drivenet core class library

## Pre-requisites
To communicate with the Google Drive API you need to have setup a project within the Google Cloud Console and have provisioned some endpoints.

[See this page for instructions](https://developers.google.com/drive/api/v3/quickstart/nodejs)

You will need the credentials.json file generated as a result of this process. This is the final part of step 1.

## Build
```
dotnet build
```

## Example usage

### Get all files at root folder
```
dotnet commandline.dll get-files
```

### Get all files in a folder
```
dotnet commandline.dll get-files [folder-id]
```

### Get all folders in root folder
```
dotnet commandline.dll get-folders
```

### Get all folders in a folder
```
dotnet commandline.dll get-folders [folder-id]
```

### Download a file
```
dotnet commandline.dll download [file-id] [destination]
```
