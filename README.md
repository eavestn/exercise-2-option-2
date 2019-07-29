# Student Management Enterprise Service Bus (ESB) Implementation

Below is a description of the local environment necessary to execute this project as well as a basic description of the 
general flow of the program. This project was completed as a part of my time at Penn. State's Masters of Software Engineering
program.

## Environment

For this project, I wanted to make use of an open-source, non-proprietary service bus library to implement my own
bus. This project is derived from the `PublishSubsribe` sample outlined by the [`Shuttle.Esb` Framework](https://github.com/Shuttle/Shuttle.Esb.Samples/tree/master/Shuttle.PublishSubscribe). For
more in-depth information on the mechanics of that framework (outside the confines of the below documentation), please consult the above-linked project.

The subscriptions are maintained by a SQL Database hosted on the same server as the project; it's configuration and
necessary set-up scripts can be found in the [`Configuration`](./Configuration) directory of this project. In order to run this project, locally, 
you will need a SQL Server instance against which the [`SubscriptionManagerCreate.sql`](./Configuration/SubscriptionManagerCreate.sql) script should
be executed. 

You will also need to configure the appropriate connection string in the [`StudentManagement.Esb.Server`](./StudentManagement.Esb.Server) `App.config`
file.

The solution itself is two Console Applications: `StudentManagement.Esb.Client` and `StudentManagement.Esb.Server` that must be running concurrently
for everything to function as expected. A command line argument `@user1` or `@user2` is then supplied to `*.Esb.Client`'s console and a corresponding
event is processed (written to the console) by the architecturally-designated Service Provider `StudentManagement.Esb.ServiceProvider.CourseRegistrar`.

In order to run this locally, you may also have to [enable local message queueing on your machine](https://docs.microsoft.com/en-us/dotnet/framework/wcf/samples/installing-message-queuing-msmq)

## Program Function

`StudentManagement.Esb.Client`'s `Program.cs` functions as the ESB Service Requester: it publishes a message (command) of type `CreateNewStudent`
against the event system maintained by `*.Esb.Server`. `*Esb.Server`'s `Server.cs` functions as our ESB: it takes on any responsibility that
might eventually be expected of a service bus. In our case, it translates the received `CreateNewStudent` command into a `NewStudentData` message
(event) that is then processed by Service Provider `*.Esb.ServiceProvider.CourseRegistrar`.

