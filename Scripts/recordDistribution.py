import folium
from folium import features
from folium.plugins import FloatImage
import webbrowser
import sqlite3
import sys, os
from pathlib import Path

def map(dbFile):
    if getattr(sys, 'frozen', False):
        # If the application is run as a bundle, the PyInstaller bootloader
        # extends the sys module by a flag frozen=True and sets the app 
        # path 
        application_path = os.path.dirname(sys.executable)
    else:
        application_path = os.path.dirname(os.path.abspath(__file__))
 
    path = Path(application_path)
    path_to_legend = str(path.parents[0]) + "\\img\\maplegend.png"
    path_to_json = str(path.parents[0]) + "\\Data\\us-states.json"

    m = folium.Map(location=[39.9116078866, -99.78682344963379],  zoom_start=5)

    # border style function
    border_style_function = lambda x: {
    'color' : x['properties']['stroke'],
    'opacity' : 2,
    }

    # main display function using the two previous functions
    BORDER_INFO = folium.features.GeoJson(path_to_json,
    name = 'borders',
    control = True,
    style_function = border_style_function,
    )

    # the tooltip is where the info display happens
    # using "folium.features.GeoJsonTooltip" function instead of basic text tooltip
    #   tooltip=folium.features.GeoJsonTooltip(
    #     # using fields from the geojson file
    #     fields=['Type', 'Name'],
    #     aliases=['Type: ', 'Name: '],
    #     style=("background-color: white; color: #333333; font-family: arial; font-size: 12px; padding: 10px;") # setting style for popup box
    #  ? )
    # ?)

    m.add_child(BORDER_INFO)

    # FloatImage(path_to_legend, bottom=0, left=87, width='250px').add_to(m)

    def add_marker(city, lat, lon):
        marker = folium.CircleMarker(location=[lat, lon], radius=1, tooltip=city)
        marker.add_to(m)

    # Connect to the SQLite database
    conn = sqlite3.connect(dbFile)
    cursor = conn.cursor()

    # Query the database for the city data
    query = "SELECT city, latitude, longitude FROM weather"
    cursor.execute(query)
    results = cursor.fetchall()

    # Loop through the results and add a marker for each city
    for result in results:
        city, lat, lon = result
        add_marker(city, lat, lon)

    m.save("map.html")
    webbrowser.open("map.html")


if __name__ == '__main__':
    if len(sys.argv) < 1:
        print("Please provide a filename as an argument.")
    else:
        dbFile = sys.argv[1]
        map(dbFile)
