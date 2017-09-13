# Swagger Codegen for the CSharpRefitCodegen Samples

## Overview

This repository contains sample scripts for building Refit client libaries for swagger based REST APIs.

### Setup

Run:
```
.\update_tools.ps1
```
This will:

1. download the [Swagger Codegen Cli](http://central.maven.org/maven2/io/swagger/swagger-codegen-cli/2.2.3/swagger-codegen-cli-2.2.3.jar) into the ./tools folder
1. Call ./swagger-csharp-refit/build.cmd to rebuild the CSharp Refit Generator.
1. Copy the CSharp Refit Generator to ./tools folder

### Usage

The gen_client.cmd files contain the call to the generator with some common configuration.

The gen_client_*.cmd files contain samples used to generate real client libraries, these effectively make calls like the following:

```
java -cp tools/CSharpRefitCodegen-swagger-codegen-1.0.0.jar;tools/swagger-codegen-cli-2.2.3.jar io.swagger.codegen.SwaggerCodegen generate -l csharprefit -i https://api.bitbucket.org/swagger.json -o ../Itofinity.Atlassian.Bitbucket --api-package Api --model-package Model -DpackageName=Itofinity.Atlassian.Bitbucket
```