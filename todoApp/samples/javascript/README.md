# client library samples for JavaScript 

These sample programs show how to use the JavaScript client libraries for in some common scenarios.
The operations include:

- create a user
- get a non-exist todo item
- create a todo item
- get the created todo item
- list all available todo items
- create a new todo item via multipart/form-data operation
- upload a local file as the attachment of the created todo item
- list all existing attachments
- delete the todo item

## Prerequisites

- The sample programs are compatible with [LTS versions of Node.js](https://github.com/nodejs/release#release-schedule).

- [.NET SDK 9.0](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) - for server

## Setup

To run the samples using the grenerated code:

1. Build grenerated code in the `todoApp/clients/javascript` folder:

```bash
npm install && npm run build
```

2. Install the dependencies using `npm` in folder `samples/javascript`:

```bash
npm install
```

3. Run the server.

```bash
dotnet run --project <RepoRoot>/todoApp/servers/aspnet/Todo.csproj
```

4. Edit the file `sample.env`, adding the correct variables. Then rename the file from `sample.env` to just `.env`. The sample programs will read this file automatically.

5. Run the samples:

```bash
npm run sample
```

