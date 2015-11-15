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

base constructor of the context class can have the following parameters
* No Parameter
* Database Name
* Connection String Name


#### No Paramter
if you donot specify the above figure base constructor of the context class then it creates a database in your Local SQLExpress Server with a name that matches your `{Namespace}.{Context Class Name}`

For Example Code First will create a database named `SchoolDataLayer.Context` for the following context class

`
namespace SchoolDataLayer
{
    public class Context : DbContext
    {
      public Context():base(){}
    }
}
`

#### Database Name
You can also specify the database name as a parameter in  a base constructor of the context class. If you specify a database name parameter, then Code First creates a database with the name you specified in the base constructor in the local SQLExpress database Server.

For Example Code FIrst will create a database Named MySchoolDB for the following Context Class
`
namespace SchoolDataLayer
{
  public class Context:DbContext
  {
    public Context():base("MySchoolDB"){}
  }
}
`

#### Connection String Name
you can also define connection string in app.config or web.config and specify connection string name starting with the base constructor of the `context class`  

Consider the following example where we pass `name = SchoolDBConnectionString` parameter in the base constructor
`
namespace SchoolDataLayer
{
  public class Context: DbContext
  {
    public SchoolDBContext():base("name=SchooLDBConnectionString"){}
  }
}
`

#### App.Config
`
<?xml version = "1.0" encoding = "UTF-8" ?>
<configuration>
  <connectionStrings>
    <add name = "SchoolDBConnectionString"
    coonnectionString = "Data Source=.; Initial Catalog = SchoolDB-ByConnectionString;Integrated Security = "true"
    providerName = "System.Data.SqlClient"/>  
  </connectionStrings>
</configuration>
`

Thus Code-First use the `base constructor` parameter to initialize a database 
