# Booking Movies

I have created an application with the following features:

- list of movies with sort and filter features.
- Search for movies. The implementation searches in the fields `title`, `plot`, `language`, `location` for the entered text.
- Display of movie details.

## Backend

For the backend I have chosen to work using .NET Core.

### Packages

- [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
- [MediatR](https://www.nuget.org/packages/MediatR)
- xUnit.net
- [Moq](https://www.nuget.org/packages/Moq)
- [Microsoft.AspNetCore.Mvc.Testing](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Testing)
- [NBuilder](https://www.nuget.org/packages/NBuilder)

### Build aplication

Enter the following command in a terminal to run application from the source code.

```
dotnet build
```

## Execute tests

Enter the following command in a terminal to run application from the source code.

```
dotnet test
```

### Run aplication

Enter the following command in a terminal to run application from the source code. Then, you can navigate to http://localhost:5000/api/movies.

```
dotnet run --project BookingMovies.WebAPI/BookingMovies.WebAPI.csproj
```

## Frontend

For the frontend I have chosen to work using Angular and Angular Material.

### Packages

- [Angular 11](https://angular.io/)
- [Angular Material](https://material.angular.io/)
- [Jest](https://jestjs.io/) - I replaced karma/jasmine by Jest.
- [DevExtreme 20.2](https://js.devexpress.com/Overview/Angular/) - I used exclusively the DataGrid component.

### Run the application

Note: we assume your command prompt is pointing to `frontend` folder.

First, install the required packages using the following command:

```dotnetcli
npm install
```

Run the application using the following command. Then, navigate to http://localhost:4200.

```dotnetcli
npm start
```

Note: it is possible to change the Web API base url in the file [`frontend/src/environment.ts`](https://github.com/stephanel/booking-movies/blob/main/frontend/src/environments/environment.ts).

### Run the tests

Enter the following command in a terminal:

```dotnetcli
npm test
```
