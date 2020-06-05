# _Pierre's Sweets & Treats_

#### June 5nd, 2020

## Description

_This application will allow the user to create a virtual collection of Sweets & Treats. Logged in users will be able to create, edit, & delete products. Viewers / site visitors can view the stock & associated qualities of the products_

_This application is meant to be viewed in the browser & will need a .NET Core Sdk 3.1 or 2.2 & ASP.Net 3.1 or 2.2 download as well as connect to a MySql Database_

## Setup/Installation Requirements

_Make sure you have [git version control](https://git-scm.com/downloads) installed on your computer._

1. Click the green 'Clone or Download' button and copy the link / download the zip
2. Open terminal and type... or skip to #4 if you downloaded the zip

**Windows**

```sh
cd desktop
```

Mac & linux

```sh
cd ~/Desktop
```

3.  in terminal type '_git clone {link to repository}_ '

```sh
git clone {link to repository}
```
4. If you downloaded the zip then extract all onto your desktop
5. Open the folder with VSC or an equivalent
6. Install .NET Core using <a href="https://docs.microsoft.com/en-us/dotnet/core/install/runtime?pivots=os-windows">this</a> link
7. Then Run the code below in the terminal to confirm installation
```sh
dotnet -- version
```  
8. In the terminal enter to confirm the proper version installed 
```sh
dotnet tool install -g 
dotnet-script
```
9. Download _[ASP.NET Core](https://dotnet.microsoft.com/download)_ To enable live viewing on a local server
10. Open project, navigate to the root folder of the project & Run the code below to enable tool connectivity
```sh
dotnet restore
```
11. Run to confirm build stability
```sh
dotnet run build 
```
12. Within that same containing folder Run _dotnet watch run_ To open a live server w/auto updated viewing
13. If you want to run tests navigate to the .tests containing folder and enter
```sh
dotnet test
```
14. Enjoy

## Implementing MySql Database w/Migrations

1. Install MySql Workbench
2. Configuration choices
  - Standalone MySQL Server
  - Let type & newtworking setting to defaults
  - Use a Legacy Auth method
  - Input your set SQL Pword
  - Do not select running as a windows service unless you want it to run on startup & always be active in the background. (Setting it as a service does mean that you wont need to run # 3 when you want to use MySql Databases)
3. Experiences my vary - I need to run MySql Community Installer and reconfigure to connect to the database everytime I bootup my computer. 
4. Create your database by selecting the triple stacked disc icon that says create new schema in the connected server and name it the same as your root project folder.
5. Implementing Migrations
6. In the root folder of your project run the code below to confirm stability

```sh
dotnet run build 
```
Then Run the code below to install entity core migration tools for database updating
```sh
dotnet tool install --global dotnet-ef
```
7. To initialize and connect your migrations run
```sh
dotnet ef migrations add Initial
```
```sh
dotnet ef database update
```

## Specs

### Behavior Driven Development Spec List
#### Pierre's Sweets & Treats
|                          Behavior                          | Input  | Output  |
| :--------------------------------------------------------: | :----: | :-----: |
| The site allows account creation | 'Email & Password' | 'Account Created' |
| The Authorized can create a flavor / treat listing | 'cheese danish' | 'cheese danish' |
| The Authorized can update a flavor / treat listing | 'buttery' | 'buttery' |
| The Authorized can delete a flavor / treat listing | 'Click delete' | 'Removed from list' |
| Visitors can view the created listing | 'View Flavors or Treats' | 'List of flavors or treats' |

---
## Known Bugs

_N/A_ - 6/5/2020

## gh-pages

WiseFool92.github.io/PSST

## Support

_Email: watkins92@gmail.com_

---
## Built With

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- [MSTest](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)

## Useful tools

- [free icons @ icons8](https://icons8.com/)
- [free icons @ fontawesome](https://fontawesome.com/)

---

- [Old School Gifs Search](https://gifcities.org/)
- [free images @ unsplash](https://unsplash.com/)

  - **_source.unsplash.com_ will return a random image at a desired size by simply calling the size after the url followed by a '?' and a keyword. Example below**

  - _https://source.unsplash.com/400x400/?cat_
  - http://unsplash.it/500/500 - This will just return a random image the size of 500x500

---

- [Flex-box Cheat Sheet](http://yoksel.github.io/flex-cheatsheet/)
- [CSS Grid Cheat Sheet](http://grid.malven.co/)

---

- [CSS Gradient BG Generator](https://mycolor.space/gradient)
- [CSS Basic Gradient Generator](https://cssgradient.io/)

---

- [CSS Dropshadow Generator](https://cssgenerator.org/box-shadow-css-generator.html)

### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Nathan Watkins-Hoagland_**
