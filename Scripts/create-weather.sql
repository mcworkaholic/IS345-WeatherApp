
CREATE TABLE weather (
    weather_id INTEGER PRIMARY KEY AUTOINCREMENT,
    city TEXT NOT NULL,
    state TEXT NOT NULL,
    region TEXT NOT NULL,
    date TEXT NOT NULL,
    year TEXT NOT NULL,
    month TEXT NOT NULL,
    day TEXT NOT NULL,
    temp REAL NOT NULL
);


  