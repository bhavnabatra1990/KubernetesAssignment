# KubernetesAssignment

# .NET Core Web API NAGPAssignment Project

This is a template for building / deploying a .NET Core Employee microservice on Kubernetes

## MAin Components of Project
```
├── Controllers
│   └── EmployeeController.cs
├── Dockerfile
├── Program.cs
├── Properties
│   └── launchSettings.json
├── README.md
├── DatabaseService
├── appsettings.json
├── NAGPAssignment.csproj
├── apply-scripts.sh
├── manifests
├── databasescript.sh
```

- `Dockerfile` is .NET Core Web API Multistage Dockerfile (following Docker Best Practices)
- `appsettings.Development.json` is .NET Core Web API development environment config
- `manifests` folder will contain Kubernetes manifests (deployment, service,configmap,pvc,pv,storageclass, database pod)
- `Program.cs` is .NET Core Web API environment variable mapping config 

## Setting Up

To setup this project, you need to clone the git repo

```sh
$ git clone https://github.com/bhavnabatra1990/KubernetesAssignment.git
$ cd KubernetesAssignment
```

To setup the docker image if need to

Docker image URL - `docker pull bhavnabatra1990/employee:tagname`

## IF build image and push

```sh
$ docker build -t bhavnabatra1990/employee:1 .
$ docker push docker.io/bhavnabatra1990/employee:1
```

## Deploying a .NET Core Web API microservice on Kubernetes

### Prerequisite:

-- docker should be installed on GKE
-- cluster has been created with enabled Network settings on GKE
-- secret should be created
-- applied permissions for chmod

- .NET Core Web API Docker Image

Preparing Config Map for .NET Core Web API microservice and use database sql server password

```sh
$ chmod +x apply-scripts.sh
$ chmod +x databasescript.sh
$ kubectl create secret generic mssql-secret --from-literal=SA_PASSWORD="" 
```

To deploy the microservice on Kubernetes, run following command:

```sh
$ ./apply-scripts.sh
```

This will deploy it on Kubernetes with the centralized config.

## Assignment Topic
`Database Tier` - used db-server.yaml
`Service Tier` - Employee service has been deployed using service.yaml
`Connectivity from outside of the Kubernetes cluster` - LoadBalancer
`No of Pods (4) and Rolling Updates Support`- Replica and rolling update strategy used in deployment.yaml for Service Tier
`Persistant Storage` - used storage class (storage.yaml), persistant volume (pv.yaml), persistant volume claim (pvc.yaml)
`Database configuration to be provided` - configMap.yaml and same environment variables has been assigned to deployment.
`database connection password` - in secret (created above and used in deployment)
`Database data should not be lost if the pod for database is re-deployed` - Persistant volume for db-server.yaml
`Pod IPs should not be used for communication between tiers` - configmap has sql-server-pod.applicationnamespace.svc.cluster.local

## Video Steps


## Learning Resources:


