namespace Github

open Newtonsoft.Json
open Newtonsoft.Json.Linq
open Fable.Remoting.Json
open System
open System.Net.Http
open System.Text
open System.IO


type GraphqlInput<'T> = { query: string; variables: Option<'T> }
type GraphqlSuccessResponse<'T> = { data: 'T }
type GraphqlErrorResponse = { errors: ErrorType list }

type GithubGraphqlClient private (httpClient: HttpClient, url: string) =

    let fableJsonConverter = FableJsonConverter() :> JsonConverter
    let settings = JsonSerializerSettings(DateParseHandling=DateParseHandling.None, NullValueHandling=NullValueHandling.Ignore, Converters = [| fableJsonConverter |])
    let serializer = JsonSerializer.Create(settings)

    /// <summary>Creates GithubGraphqlClient specifying <see href="T:System.Net.Http.HttpClient">HttpClient</see> instance</summary>
    /// <remarks>
    /// In order to enable all F# types serialization and deserealization
    /// <see href="T:Fable.Remoting.Json.FableJsonConverter">FableJsonConverter</see> is added
    /// from <a href="https://github.com/Zaid-Ajaj/Fable.Remoting">Fable.Remoting.Json</a> NuGet package
    /// </remarks>
    /// <param name="url">GraphQL endpoint URL</param>
    /// <param name="httpClient">The HttpClient to use for issuing the HTTP requests</param>
    new(url: string, httpClient: HttpClient) = GithubGraphqlClient(httpClient, url)

    /// <summary>Creates GithubGraphqlClient with a new <see href="T:System.Net.Http.HttpClient">HttpClient</see> instance</summary>
    /// <remarks>
    /// In order to enable all F# types serialization and deserealization
    /// <see href="T:Fable.Remoting.Json.FableJsonConverter">FableJsonConverter</see> is added
    /// from <a href="https://github.com/Zaid-Ajaj/Fable.Remoting">Fable.Remoting.Json</a> NuGet package
    /// </remarks>
    /// <param name="url">GraphQL endpoint URL</param>
    new(url: string) = GithubGraphqlClient(url, new HttpClient())

    /// <summary>Creates GithubGraphqlClient specifying <see href="T:System.Net.Http.HttpClient">HttpClient</see> instance</summary>
    /// <remarks>
    /// In order to enable all F# types serialization and deserealization
    /// <see href="T:Fable.Remoting.Json.FableJsonConverter">FableJsonConverter</see> is added
    /// from <a href="https://github.com/Zaid-Ajaj/Fable.Remoting">Fable.Remoting.Json</a> NuGet package
    /// </remarks>
    /// <param name="httpClient">The HttpClient to use for issuing the HTTP requests</param>
    new(httpClient: HttpClient) =
        if httpClient.BaseAddress <> null then
            GithubGraphqlClient(httpClient.BaseAddress.OriginalString, httpClient)
        else
            raise(ArgumentNullException("BaseAddress of the HttpClient cannot be null for the constructor that only accepts a HttpClient"))
            GithubGraphqlClient(String.Empty, httpClient)
    
    member _.CurrentUserAsync() =
        async {
            let query = """
                query CurrentUser {
                  viewer {
                    login
                  }
                }
            """
            
            let inputJson = JsonConvert.SerializeObject({ query = query; variables = None }, settings)
            let! response =
                httpClient.PostAsync(url, new StringContent(inputJson, Encoding.UTF8, "application/json"))
                |> Async.AwaitTask

            let! responseContent = Async.AwaitTask(response.Content.ReadAsStreamAsync())
            use sr = new StreamReader(responseContent)
            use tr = new JsonTextReader(sr)
            let responseJson = serializer.Deserialize<JObject>(tr)

            match response.IsSuccessStatusCode with
            | true ->
                let errorsReturned =
                    responseJson.ContainsKey "errors"
                    && responseJson.["errors"].Type = JTokenType.Array
                    && responseJson.["errors"].HasValues

                if errorsReturned then
                    let response = responseJson.ToObject<GraphqlErrorResponse>(serializer)
                    return Error response.errors
                else
                    let response = responseJson.ToObject<GraphqlSuccessResponse<CurrentUser.Query>>(serializer)
                    return Ok response.data

            | errorStatus ->
                let response = responseJson.ToObject<GraphqlErrorResponse>(serializer)
                return Error response.errors
        }

    member this.CurrentUser() = Async.RunSynchronously(this.CurrentUserAsync())
