#!/bin/bash

# List the manifest files in the desired order1
FILES=(
  "manifests/namespace.yaml"
  "manifests/configmap.yaml"
  "manifests/storageclass.yaml"
  "manifests/networking.yaml"
  "manifests/deployment.yaml"
  "manifests/db-server.yaml"
  "manifests/service.yaml"
)

# Iterate over the files and apply them
for file in "${FILES[@]}"
do
  kubectl apply -f "$file"
done
