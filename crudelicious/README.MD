# Starting a COMPLETE STACK

TO START NEW PROJECT:<br>
    dotnet new mvc --no-https   // for development <br>
    dotnet new mvc              // for production<br>

TO RUN NEW PROJECT:<br>
    // server needs to be restarted after changes<br>
    dotnet run    <br>        
    // server will restart and run after each file save;<br> 
    dotnet watch run        <br>

TO ADD MVC SERVICES<br>
    place


ENTITY FRAMEWORK CORE INSTALL:<br>
    // This installs globally only need to do it once EVER on your system<br>
    ```dotnet tool install --global dotnet-ef```  <br>
    

ADDING PACKAGES (in terminal):<br>
   
    ```dotnet add package Pomelo.EntityFrameworkCore.MySql --version 3.1.1``` <br>
    
    ```dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.5``` <br> 


```C# using System;
using System.ComponentModel.DataAnnotations;
namespace Monsters.Models
{
    public class Monster
    {
        [Key]
        public int MonsterId { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
 ```


 ### CREATING DATABASE MIGRATIONS<br>

 ``` dotnet ef migrations add YourMigrationName ``` <br>
    **Either or**
 ``` dotnet ef migrations add FirstMigration``` <br>

    --TO APPLY TO DATABASE
    dotnet ef database update