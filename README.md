# SCRABBLE SCOREKEEPER WINFORMS DESKTOP APPLICATION

<!-- ABOUT THE PROJECT -->
## About The Project

* It is a CRUD desktop application developed in WinForms that targets .NET Framework 4.7.2
* This is the desktop version of Scrabble Scorekeeper

![Homepage](AppScreenshots/homepage1.jpg)

## Built With
* C#
* SQL Server
* Dapper
* LINQ queries
* xUnit for Unit Testing 
* Visual Studio 2019
* The solution has 3 projects: UI, class library and data access layers

## Overview

* ### Add players and their scores during each round. Tally the results and display them in the scoreboard

![Main Functionality](AppGifs/RazorPagesScorekeeper.gif)

* ### Edit players' names
##### (Editing scores without playing would be cheating so it is not allowed)

![Edit Player](AppGifs/edit.gif)

* ### Delete a player from the database

![Delete Player](AppGifs/delete.gif)

## Data Validation

* ### The app doesn't accept the same name twice

![Same-name-entered-twice validation](AppGifs/SameUserValidation.gif)

* ### The same user can't be selected twice during the same game

![Same-user-selected-twice validation](AppGifs/SelectingSameUserVal.gif)

* ### Users can't enter null/empty data to the database

![Force user to enter scores validation](AppGifs/NoStartVal.gif)

* ### Negative scores are not allowed

![No-negative-numbers validation](AppGifs/NegativeNumVal.gif)

