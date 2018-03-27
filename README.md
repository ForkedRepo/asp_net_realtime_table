# BUILD REALTIME TABLE USING ASP.NET

We often need to display data in a table. However, unless it’s a realtime table, we need to reload to view new data each time that it’s added. For example, take a table of movies arranged by the year they were released. Each time a movie is added, we would not know of the changes until we reload our page - which is not the best experience for a user.

Today, we will solve this problem by creating a realtime table of movie titles, which updates once there is new data. The full tutorial can be found here : [https://pusher.com/tutorials/realtime-table-aspnet/ ](https://pusher.com/tutorials/realtime-table-aspnet/) 

## Getting Started
Clone the project repository by running the command below if you use SSH

```
git clone git@github.com:samuelayo/asp_net_realtime_table.git
```

If you use https, use this instead

```
git clone https://github.com/samuelayo/asp_net_realtime_table.git
```

After cloning, open the `pusher_realtime_table.sln` file in visual studio.


### Prerequisites

#### Setup Pusher

If you don't have one already, create a free Pusher account at https://pusher.com/signup then login to your dashboard and create an app. 


Then fill in your Pusher app credentials in your `Controllers\HomeController` file by replacing this line with your appid, appkey and app secret respectively:

```
var pusher = new Pusher("PUSHER_APP_ID", "PUSHER_APP_KEY", "PUSHER_APP_SECRET", options);
```

Also, remember to fill in the your secret key and app cluster in your `Views\Home\view.cshtml` file by updating this line:

```
var pusher = new Pusher('PUSHER_APP_KEY', {cluster: 'XXX_CLUSTER'});
```

And finally, start the application by clicking the debug button on your visual studio.

## Built With

* [Pusher](https://pusher.com/) - APIs to enable devs building realtime features
* [ASP.NET](https://www.asp.net/) - Open source web framework for building modern web apps and services with .NET. 
* [Vue.js](https://vuejs.org/) - The Progressive JavaScript Framework

