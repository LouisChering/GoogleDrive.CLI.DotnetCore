# Google drive project CLI

This is a .net core command line project that use the drivenet core class library


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