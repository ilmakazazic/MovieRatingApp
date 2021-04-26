# Movie Rating App

Application that allows you to rate a specific movie and shows top rated movies.


## Technologies 

Created with .NET Core on a backend side and Angular on a frontend side.

## How to run project

Download the project. 

Find **.bak** file in the folder and **restore a database** with all data. 
Run a .NET Core (MovieRatingApp) project  with or without debbuger to start API on your machine.
Run Angular (MovieRatingApp.Client) project using `ng serve -o` in the terminal. Navigate to `http://localhost:4200/`. 

## How to use project

When the application starts there will be a list of 10 movies sorted by top rated, two tabs Movies and TV Show and search input field. There is a possibility to load more movies/TV shows or filter content by typing any words in a search bar. Each movie/TV show has its own rating stars that shows average points and by clicking on them it is possible to give a rate. 

API has authentification for only one endpoint (Get users) and this endpoint is not used on the client side of the application.

Test data:
    - username: test
    - password: testtest



