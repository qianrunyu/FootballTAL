The program is in winform following the MVC pattern.

A unit test project has been included in this exercise with a 92% code coverage simulating real world coding developement envrionment.

The file reading class implements Dependency Injection pattern which allows multiple file format reading engine to have one common read function. Curently CSV format is supported.

No logic coding in code behind file for better UI separation and easier unit testing.

FootballClub.cs maps the structure in .csv file. Extra attributes such as errorFound and Smallest difference are store in FootballClubExtention.cs which inherites the parent class.

There is a "continue on error" check box in UI which means if some errors found in the cell, the reading engine will ingore current row and continue on next row without stopping.

Uncheck "continue on error" will terminate the process if any problem found in the file.

The resources folder in testing project contains some csv files which have common erros such as no header, errors in cell or missing columns in certian rows.
