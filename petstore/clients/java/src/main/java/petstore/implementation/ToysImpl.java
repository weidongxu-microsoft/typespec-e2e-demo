// Code generated by Microsoft (R) TypeSpec Code Generator.

package petstore.implementation;

import io.clientcore.core.annotation.ServiceInterface;
import io.clientcore.core.http.RestProxy;
import io.clientcore.core.http.annotation.HeaderParam;
import io.clientcore.core.http.annotation.HostParam;
import io.clientcore.core.http.annotation.HttpRequestInformation;
import io.clientcore.core.http.annotation.PathParam;
import io.clientcore.core.http.annotation.QueryParam;
import io.clientcore.core.http.annotation.UnexpectedResponseExceptionDetail;
import io.clientcore.core.http.exception.HttpResponseException;
import io.clientcore.core.http.models.HttpMethod;
import io.clientcore.core.http.models.RequestOptions;
import io.clientcore.core.http.models.Response;
import petstore.PetStoreError;
import petstore.Toy;
import petstore.ToyCollectionWithNextLink;

/**
 * An instance of this class provides access to all the operations defined in Toys.
 */
public final class ToysImpl {
    /**
     * The proxy service used to perform REST calls.
     */
    private final ToysService service;

    /**
     * The service client containing this operation class.
     */
    private final PetStoreClientImpl client;

    /**
     * Initializes an instance of ToysImpl.
     * 
     * @param client the instance of the service client containing this operation class.
     */
    ToysImpl(PetStoreClientImpl client) {
        this.service = RestProxy.create(ToysService.class, client.getHttpPipeline());
        this.client = client;
    }

    /**
     * The interface defining all the services for PetStoreClientToys to be used by the proxy service to perform REST
     * calls.
     */
    @ServiceInterface(name = "PetStoreClientToys", host = "{endpoint}")
    public interface ToysService {
        @HttpRequestInformation(
            method = HttpMethod.GET,
            path = "/pets/{petId}/toys/{toyId}",
            expectedStatusCodes = { 200 })
        @UnexpectedResponseExceptionDetail(exceptionBodyClass = PetStoreError.class)
        Response<Toy> getSync(@HostParam("endpoint") String endpoint, @PathParam("petId") int petId,
            @PathParam("toyId") long toyId, @HeaderParam("Accept") String accept, RequestOptions requestOptions);

        @HttpRequestInformation(method = HttpMethod.GET, path = "/pets/{petId}/toys", expectedStatusCodes = { 200 })
        @UnexpectedResponseExceptionDetail(exceptionBodyClass = PetStoreError.class)
        Response<ToyCollectionWithNextLink> listSync(@HostParam("endpoint") String endpoint,
            @PathParam("petId") int petId, @QueryParam("nameFilter") String nameFilter,
            @HeaderParam("Accept") String accept, RequestOptions requestOptions);
    }

    /**
     * Gets an instance of the resource.
     * <p><strong>Response Body Schema</strong></p>
     * 
     * <pre>
     * {@code
     * {
     *     id: long (Required)
     *     petId: long (Required)
     *     name: String (Required)
     * }
     * }
     * </pre>
     * 
     * @param petId The petId parameter.
     * @param toyId The toyId parameter.
     * @param requestOptions The options to configure the HTTP request before HTTP client sends it.
     * @throws HttpResponseException thrown if the service returns an error.
     * @return an instance of the resource.
     */
    public Response<Toy> getWithResponse(int petId, long toyId, RequestOptions requestOptions) {
        final String accept = "application/json";
        return service.getSync(this.client.getEndpoint(), petId, toyId, accept, requestOptions);
    }

    /**
     * The list operation.
     * <p><strong>Response Body Schema</strong></p>
     * 
     * <pre>
     * {@code
     * {
     *     value (Required): [
     *          (Required){
     *             id: long (Required)
     *             petId: long (Required)
     *             name: String (Required)
     *         }
     *     ]
     *     nextLink: String (Optional)
     * }
     * }
     * </pre>
     * 
     * @param petId The petId parameter.
     * @param nameFilter The nameFilter parameter.
     * @param requestOptions The options to configure the HTTP request before HTTP client sends it.
     * @throws HttpResponseException thrown if the service returns an error.
     * @return paged response of Toy items.
     */
    public Response<ToyCollectionWithNextLink> listWithResponse(int petId, String nameFilter,
        RequestOptions requestOptions) {
        final String accept = "application/json";
        return service.listSync(this.client.getEndpoint(), petId, nameFilter, accept, requestOptions);
    }
}
