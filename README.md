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
-- applied permissions for chmod

- .NET Core Web API Docker Image

Preparing Config Map for .NET Core Web API microservice and use database sql server password

```sh
$ chmod +x apply-scripts.sh
$ chmod +x databasescript.sh
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
`Persistant Storage` - used storage class (storage.yaml), persistant volume claim (pvc.yaml)
`Database configuration to be provided` - configMap.yaml and same environment variables has been assigned to deployment.
`Database connection password` - in secret (created above and used in deployment)
`Database data should not be lost if the pod for database is re-deployed` - Persistant volume for db-server.yaml
`Pod IPs should not be used for communication between tiers` - configmap has sql-server-pod.applicationnamespace.svc.cluster.local
  and used network-policy.yaml
`Database job database-job.yaml is used to install sql tools and create empty database`
`ingress networking.yaml is used to give external name Service API tier URL`

## Deliverables
Source Code for the project. Provide repository URL, don’t upload whole source code.
o Make sure it includes all Kubernetes YAML files used in the assignment. - manifests folder
o Dockerfile should be present as well. - Dockerfile
o Repository can be GitHub or Gitlab. - https://github.com/bhavnabatra1990/KubernetesAssignment.git
• Also include a README file in code which has: README file is there

`namespace.yaml` - to create applicationnamespace having all resources here
`network-policy` - To allow FQDN as Pod IPs should not be used for communication between tiers.
`configmap.yaml` - database configuration
`secret.yaml` - database password
`storageclass.yaml` - storage class for database
`pvc.yaml` - persistant volume claim for database
`db-server.yaml.yaml` - database headless service Database tier
`deployment.yaml` - deployment of pods
`service.yaml` - Service api tier
`networking.yaml` - Service API tier URL generation
`database-job.yaml` - database commands to install sql tools and create database

## Video Steps
▪ Show all objects deployed and running.

kubectl get namespace
kubectl get secret
kubectl get configmap
kubectl get storageclass
kubectl get pvc
kubectl get ingress
kubectl get NetworkPolicy
kubectl get deployment
kubectl get pods
kubectl get services


▪ Show an API call retrieving records from database.
http://34.171.29.209/swagger/index.html

▪ Kill API microservice pod and show it regenerates.

kubectl delete pod employeeapp-deployment-757ff6f876-2gnnp


▪ Kill database pod and show it regenerates and keeps old data.
kubectl delete pod mssql-0 

## Learning Resources:

https://cloud.google.com/kubernetes-engine
https://kubernetes.io/docs/concepts/storage/storage-classes/


