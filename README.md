A simple ASP.Net Core 3.1 Web API project with a single
HTTP GET API.

Run it from the command line as `dotnet run`. The command
will start a development server locally on a random port
and the command output will show the URL on which the API
can be accessed.

The API can be invoked by sending an HTTP GET request to
the URL `/api/isotopes/{symbol}` on the local server. For
example, if the local server is available on
`https://localhost:7902`, the GET request
`https://localhost:7902/api/isotopes/H` will show information
for Hydrogen, `https://localhost:7902/api/isotopes/C` will
show information for Carbon and so on. Only the first 10
elements from the periodic table are supported.