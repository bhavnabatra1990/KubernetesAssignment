#!/bin/bash

# SQL script to create the database

sqlcmd -S $SA_HOST -U $SA_USER -P $SA_PASSWORD -d $SA_DATABASE -Q "databaseService/sqldatabasescript.sql"


