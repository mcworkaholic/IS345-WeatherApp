#!/usr/bin/python3
import sys
import os
import pandas as pd
import matplotlib.pyplot as plt
import sqlite3
from pathlib import Path


"""
This script is designed to plot a multiple time series of average monthly maximum temperature by region. 
It takes in three command line arguments: the filename of the SQLite3 database, the begin year and end year to query the data.
The script first connects to the SQLite3 database using the provided filename and queries the data using the provided begin year and end year as parameters. 
The data is then read into a Pandas DataFrame and preprocessed to ensure that it is in the correct format for plotting.
The script then uses the Matplotlib library to create a multiple time series plot of the data, with each region represented by a different line. The plot is saved to the 'img' directory with the name 'plot.png'

"""

def plot(filename, begin_year, end_year):
    if getattr(sys, 'frozen', False):
        # If the application is run as a bundle, the PyInstaller bootloader
        # extends the sys module by a flag frozen=True and sets the app 
        # path 
        application_path = os.path.dirname(sys.executable)
    else:
        application_path = os.path.dirname(os.path.abspath(__file__))

    con = sqlite3.connect(filename)
    sql = """SELECT region, date_utc, year, month, temp, AVG(temp) FROM weather WHERE year >= ? AND year <= ? GROUP BY region, year, month"""

    # Read the data from the local database into a Pandas DataFrame with the commandline arguments
    data = pd.read_sql_query(sql, con, params=[begin_year, end_year])
    data['date_utc'] = pd.to_datetime(data['date_utc'])
    data['temp'] = pd.to_numeric(data['temp'], errors='coerce')
    data = data.set_index('date_utc')
    data = data.sort_index()
    data = data.interpolate()
    
    path = Path(application_path)
    path_to_img = str(path.parents[0]) + "\\img\\plotting\\plot.png"
    #print(str(path.parents[0]) + "\\img\\plotting\\plot.png") -> debugging filepath
    
    
    try:
        os.remove(path_to_img)
    except OSError:
        pass
    
    # Create the multiple time series plot
    plt.figure(figsize=(17, 8))
    
    for region in data.region.unique():
        region_data = data[data.region==region]
        try:
            plt.plot(region_data.index, region_data.temp, label=region)
        except ValueError:
            pass
    
    plt.title("Temperature By Region")
    plt.xlabel('Year')
    plt.ylabel('Temperature')
    plt.legend(bbox_to_anchor=(1.01, -0.10), loc='lower right')
    plt.tight_layout()
    plt.savefig(path_to_img)
    plt.close()


if __name__ == '__main__':
    if len(sys.argv) < 2:
        print("Please provide a filename as an argument.")
    else:
        filename = sys.argv[1]
        begin_year = sys.argv[2]
        end_year = sys.argv[3]
        plot(filename, begin_year, end_year)

