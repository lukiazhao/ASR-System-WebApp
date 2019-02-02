# ASR-System-WebApp
Appointment Scheduling and Reservation System in .net core


-Why using Angular and WebApi for Dashboard

Angular:

One of the biggest advanteges of using Angular is Angular supports Single Page Application (SPA). SPA project only contains one page which can bring many benifits to performance and user friendly. First, there is no full page refreshment in SPA, only partial refresh. This is good for improving performance because no extra requests needed to the server to download new pages. The time of loading web pages could be shorten significantly and it also reduces the workload for the server side. 

Secondly, since Dashboard has a small scope and limited amount of features. It is well suited with a single page design. User can get all information on a cleaner and lighter web page and easy to explore. At last, Angular provides a lot of built-in tools to help developing a good looking web page and demand less codes in some cases. For example, we don't have to write code that manually synchronizes the Model and the View - that code is generated for us automatically by Angular.


WebApi:

The WebApi helps us to seperate the database logic and the front-end project. All the logic about connecting server and updating databases can be hiden behind WebApi. The front-end project only use those methods in Api by sending url requests without knowing all the information related to database. This approach can improve the security of the back-end and help server side to protect their implementation logic and data itself. For example, if users knows the connection string of Sql server from the source code they can connect to the server and access to all the data in the database. And project without using api could leak business secret to clients by exposing them all the business logic in validation part. 

From a perspective of developer, the WebApi helps us to create a more clean and solid project structure. Both front-end and back-end can focus on their job totally following a good Object-Oriented practice that all the codes can encapsulated and provide suitable access control to different parties. In the end, WebApi also enable us to publish or share the project for other developers. For instance, other developers can use WebApi in DashBoard in their own projects.



-References

Part A and B: 

.Net Core 2.1 Tutorial by Microsoft:  https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-2.2&tabs=visual-studio 

Sample AsrSystem by Matthew Bolger: tutorial material in Week 9

Part C:

Sample Employee Application by Metthew Bolger: tutorial meterial in Week 11






