# MovieRatingSystem-PublicRepo
To test the project locally, go through following steps:
- Replace database credentials in appsettings with your own (for MySQL server)
- Run Update-Database in Package Manager Console to seed the database with test data
- Optionally, if your version of VisualStudio does not implicitly override global NuGet config with this project's one, add a package source:
  - Name: DevExpress
  - Source: https://nuget.devexpress.com/LhbqLoFVSAdIVAYehqDjygfZQ2mwkf94aYAh7FlIlytsjDbNtM/api
