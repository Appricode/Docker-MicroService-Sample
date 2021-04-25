# Basic .Net 5 Docker Microservice Reference Application 
This repo contains a project which has the main API and two microservices.  

The aim of the project to show; how the **docker file** and **docker-compose** file has to be. 

  ## Architecture   
    Api  
    MicroService1  
    MicroService2  
    
  ## How to run 
    docker-compose up
    
  ## How to stop 
    docker-compose down --rmi all

  ## How to test
    The main API runs on 4001 and can call other microservices
    curl --location --request GET 'https://localhost:4001/Resolver/1' => Returns  MicroService-1
    curl --location --request GET 'https://localhost:4001/Resolver/2' => Returns  MicroService-2
