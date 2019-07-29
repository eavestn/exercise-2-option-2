# Student Management Enterprise Service Bus (ESB) Implementation

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



