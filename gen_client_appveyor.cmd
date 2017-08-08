rmdir /S /Q clients\Itofinity.Appveyor.Rest.Refit
call gen_client.cmd ^
-i https://raw.githubusercontent.com/kevinoid/appveyor-swagger/master/swagger.yaml ^
-o ^
clients/Itofinity.Appveyor.Rest.Refit --api-package Api --model-package Model -DpackageName=Itofinity.Appveyor.Rest.Refit