# Pulumi Providers Operations Tool

A tool for managing Pulumi providers operations.

### Install via Pulumi 
Using the Pulumi CLI (requires CLI v3.121.0 or later)

```
pulumi plugin install tool props --server github://api.github.com/Zaid-Ajaj
```

After installing the plugin, you can run it using the following command:

```
pulumi plugin run props
```
It will spin up a web server running at `http://localhost:5000` where you can navigate to interact with the tool.

### Uninstall via Pulumi

To uninstall the plugin, you can run the following command:

```
pulumi plugin rm tool props
```

### Update to latest version

You can uninstall and reinstall the plugin to get the latest version of the tool.

### Development

In the root of the repo:
```
dotnet tool restore
dotnet run
```

This will run both the server and client in parallel
 - server on `http://localhost:5000`
 - client on `http://localhost:8080`

Requests made from the client are proxied to the server.

### Running server and client separately

Run server and client in watch mode in two different terminal tabs:

for the server:
```
cd src/Server
dotnet run
```
for the client:
```
cd src/Client
dotnet fable watch -o output -s --run npm run start
```
