set PROJ_NAME=Itofinity.Appveyor.Rest.Refit
rem rmdir /S /Q ..\%PROJ_NAME%
call gen_client.cmd ^
-i https://raw.githubusercontent.com/kevinoid/appveyor-swagger/master/swagger.yaml ^
-o ^
../%PROJ_NAME% --api-package Api --model-package Model -DpackageName=%PROJ_NAME%