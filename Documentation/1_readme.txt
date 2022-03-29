To access SQL with command line, go to: https://www.sqlite.org/download.html
(1) Download and Unzip the tool;
(2) Verify the tool is on your path

	> sqlite3 -version
      3.38.2 2022-03-26 ...

(3) Create your database in your current folder:

	> sqlite3 test.db < data_schema.sql
	> sqlite3 test.db < data_init.sql

------------------------------------------------------------------------------

You can also create your database with GUI tools such as 
"DB Browser for SQLite" or "SQLiteStudio". I'm using SQLiteStudio

