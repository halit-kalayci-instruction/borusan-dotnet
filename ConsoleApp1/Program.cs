using ConsoleApp1;



// instance
BaseDbAccess baseDbAccess = new MariaDbDataAccess();

baseDbAccess.ConnectToDatabase();
baseDbAccess.NotCommonFunction();

