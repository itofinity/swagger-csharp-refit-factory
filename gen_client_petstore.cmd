rmdir /S /Q clients\petstore
call gen_client.cmd -i http://petstore.swagger.io/v2/swagger.json  -o clients/petstore