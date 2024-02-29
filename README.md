# Clients for the Route Optimization OptiFlow API

Using client classes makes it easier and more convenient to integrate the API into an existing programming environment. We provide here clients for Java, C# and TypeScript. Alternatively you can generate the clients yourself by using this [tutorial](https://developer.myptv.com/en/resources/tutorials/general/how-generate-clients-ptv-developer-apis).


Language depending information:
* **DotNet:** Please add the following nuget packages to your client project
  * Please use .NET 6.0
  * JsonSubTypes (1.8.0)
  * Polly (7.2.3)
  * RestSharp (106.13.0)
  * System.ComponentModel.Annotations (5.0.0)
  
  To initialize your client with your APIKey you can use the following snippet:
    ```
     var apiKey = new Dictionary<string, string>(){["apiKey"] = "Enter your ApiKey here" };
     var configuration = new Configuration() { ApiKey = apiKey };
     PlansApi plansApi = new PlansApi(configuration);
    ```
  If your APIKey allows for at least 5000 Orders, before you start a big Optimization in class OptimizationAPI, you may have to compress your payload. For this
    * set ``` localVarRequestOptions.HeaderParameters.Add("Content-Encoding", "gzip"); ```
    * use compressed data as body of your http request
      ```
       MemoryStream memStream1 = new MemoryStream();
       BinaryFormatter binFormatter = new BinaryFormatter();
       binFormatter.Serialize(memStream1, optimizationRequest);
       byte[] data = memStream1.ToArray();
       MemoryStream memStream2 = new MemoryStream();
       GZipStream gzStream = new GZipStream(memStream2, CompressionMode.Compress);
       gzStream.Write(data, 0, data.Length);
       localVarRequestOptions.Data = memStream2.ToArray();
      ```

* **Java:** Please add the following dependencies to your project
  ```   <dependencies>
        <dependency>
            <groupId>com.fasterxml.jackson.core</groupId>
            <artifactId>jackson-core</artifactId>
            <version>2.10.4</version>
        </dependency>
        <dependency>
            <groupId>com.fasterxml.jackson.core</groupId>
            <artifactId>jackson-annotations</artifactId>
            <version>2.10.4</version>
        </dependency>
        <dependency>
            <groupId>com.fasterxml.jackson.core</groupId>
            <artifactId>jackson-databind</artifactId>
            <version>2.10.4</version>
        </dependency>
        <dependency>
            <groupId>com.fasterxml.jackson.datatype</groupId>
            <artifactId>jackson-datatype-jsr310</artifactId>
            <version>2.10.4</version>
        </dependency>
        <dependency>
            <groupId>org.openapitools</groupId>
            <artifactId>jackson-databind-nullable</artifactId>
            <version>0.2.1</version>
        </dependency>
        <dependency>
            <groupId>com.github.ptv-logistics</groupId>
            <artifactId>openapi-generator-cli</artifactId>
            <version>6.2.1</version>
        </dependency>
        <dependency>
            <groupId>javax.ws.rs</groupId>
            <artifactId>javax.ws.rs-api</artifactId>
            <version>2.1.1</version>
        </dependency>
  ```       
   To initialize your client with your APIKey you can use the following snippet:
    ```
     ApiClient apiClient = Configuration.getDefaultApiClient()
       .setRequestInterceptor(builder -> builder.setHeader("ApiKey", "Enter your ApiKey here"));
     PlansApi plansApi = new PlansApi(apiClient);
    ```
   If your APIKey allows for at least 5000 Orders, before you start a big Optimization in class OptimizationAPI, you may have to compress your payload. For this
    * set ``` localVarRequestBuilder.header("Content-Encoding", "gzip"); ```
    * use compressed data as body of your http request
      ```
       byte[] localVarPostBody = memberVarObjectMapper.writeValueAsBytes(optimizationRequest);
       String requested = new String(localVarPostBody, StandardCharsets.UTF_8);
       ByteArrayOutputStream baOutStream = new ByteArrayOutputStream();
       GZIPOutputStream gzipOutStream = new GZIPOutputStream(baOutStream);
       gzipOutStream.write(localVarPostBody, 0, localVarPostBody.length);
       gzipOutStream.close();
       byte[] localVarPostBody_1 =  baOutStream.toByteArray();
      ```

* **TypeScript:** Please add the following dependecies to your project
  * aurelia-api (3.2.1)
  * aurelia-fetch-client (1.8.2)
  * node-fetch (2.6.1)
  * polly-js (1.8.0)
  * typescript (4.1.2)
  * @types/node (18.11.18)
  * typescript-http-client (0.10.1)
  
  
  To initialize your client with your APIKey you can use the following snippet:
    ```
    let configurationParameters: ConfigurationParameters = {fetchApi: require('node-fetch'),
                                                            headers: {ApiKey: "Enter your ApiKey here"}};
    let configuration: Configuration = new Configuration(configurationParameters);
    let plansApi: PlansApi = new PlansApi(configuration);
    ```
  If your APIKey allows for at least 5000 Orders, before you start a big Optimization in class OptimizationAPI, you may have to compress your payload. For this
    * set ``` headerParameters['Content-Encoding'] = 'gzip'; ```
    * use compressed data as body of your http request
      ```
       const jsonString = JSON.stringify(requestParameters.optimizationRequest);
       const data = new TextEncoder().encode(jsonString);
       const compressedData = await gzipModule.compress(data);
      ```

 &nbsp;  
 &nbsp;  
 Please refer to our [Route Optimization Optiflow API](https://developer.myptv.com/en/documentation/route-optimization-optiflow-api-experimental/quick-start-route-optimization-optiflow) documentation.