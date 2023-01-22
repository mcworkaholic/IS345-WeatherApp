import sys
import os
import pandas as pd
import matplotlib.pyplot as plt
import sqlite3

def plot(filename):
    con = sqlite3.connect(filename)
    # Read the data from the local database into a Pandas DataFrame
    data = pd.read_sql_query("SELECT region, date, year, month, temp, AVG(temp) FROM weather WHERE year >= 2000 AND year <= 2010 GROUP BY region, year, month", con)
    data['date'] = pd.to_datetime(data['date'], format='%m/%d/%Y')
    data['temp'] = pd.to_numeric(data['temp'], errors='coerce')
    data = data.set_index('date')
    data = data.sort_index()
    data = data.interpolate()
    
    path = os.path.dirname(os.path.dirname( __file__ ))
    print(path)
    # Create the multiple time series plot
    plt.figure(figsize=(17, 8))
    
    for region in data.region.unique():
        region_data = data[data.region==region]
        try:
            plt.plot(region_data.index, region_data.temp, label=region)
        except ValueError:
            pass
    #print(region_data)
    plt.title("Average Monthly Max Temperature By Region")
    plt.xlabel('Year')
    plt.ylabel('Monthly Max Temperature')
    plt.legend(bbox_to_anchor=(1.01, -0.10), loc='lower right')
    plt.tight_layout()
    plt.savefig(path + "\\img\\plot.png")


if __name__ == '__main__':
    if len(sys.argv) < 2:
        print("Please provide a filename as an argument.")
    else:
        filename = sys.argv[1]
        plot(filename)

