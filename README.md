# Entity Framework Code First Notes
entity framework is a great tool for doing Database manipulations of your Application. All the Time we need to use Database for managing data. the same job we have to do over and over again. But **Entity Framework** makes the job easier by writing all the boilerplate codes for you. There are 3 types of Entity Framework 

1. Code First
2. Model First
3. Database First

![workflow of EF](https://i-msdn.sec.s-msft.com/dynimg/IC613437.png)

#Code First Approach
Code First Mainly useful for **Domain Driven Design** 

![Code First A Domain Driven Design Approach Of Entity Framework](http://www.entityframeworktutorial.net/images/EF5/code-first.png)

## Basic Workflow
1. Write Application Domain & Context Classexs
2. Configure Domain Classes For Additional Mapping Requirements
3. Build Application
4. Code First API to create a new database or map existing Database with Domain Classes
5. Seed Default/Test Data into the Database 
6. finally Launch the Application

## Database Initialization

![Database initialization](http://www.entityframeworktutorial.net/images/codefirst/database-init-fg1.PNG)

