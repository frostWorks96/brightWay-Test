# brightWay-Test

This is my compleated cooding project.

the exe is located in brightway\brightway\bin\Debug\net5.0

the exe needs to be ran in the command prompt to display. Other wise it will run and close really fast.

it does run out of the box. It has four classes one is a header to make 
changing the number of toppings shown at the end more manageable, and 
the other is the link to the JSON code. To make changing it to a 
different HTML location easier.

The Toppings class is used to store the JSON data in a class and 
sort the data to make it easier to organize later. It contains 
two properties. A list of strings for the JSON data and an 
int to track how many times the data is used.

The next class is the JsonControl class. This class is used to 
manipulate JSON data.

I commented on the methods to make it easier to understand 
what was happening in the code.

 



This is an assesment made by Brightway.

Code Test:

We want you to create a small application (can be a console app or web application).

This application should only take about an hour to complete. What we are looking for is how you approach a problem and see how you can write clean/simple code to execute requirements. We would like to see a good use of .NET features (things like linq, lambda or lists<> just as an example).
Here are the details needed to complete the test:

    We will provide a sample order of pizza toppings =>
    brightway.com/pizzas.json
    .
    To pull the pizza toppings, we will want you to pull in the data using either WebClient or HttpWebRequest.
    Group the list of topping combinations with a count of how many times they were used.
    Order the list from the most ordered to the least.
    Display the top 20 most frequently ordered pizza configurations, listing the toppings for each and the number of times that pizza configuration has been ordered.

What to do after completion.

Once you are done, we will want you to either upload the application to GitHub, Bitbucket, GitLab or any code repository you like to use.

Make sure that the code will run after cloning. We want to make sure all applications run out of the box for the next developer.

Add a README file with any information you want us to know about your code.

Notify us when this is completed and provide a link to pull down the code.
