#!/bin/bash

# List the manifest files in the desired order
FILES=(
  "manifests/namespace.yaml"
  "manifests/secret.yaml"
  "manifests/configmap.yaml"
  "manifests/storageclass.yaml"
  "manifests/databasedeployment.yaml"
  "manifests/db-server.yaml"
  "manifests/deployment.yaml"
  "manifests/service.yaml"
)

# Iterate over the files and apply them
for file in "${FILES[@]}"
do
  kubectl apply -f "$file"
done
